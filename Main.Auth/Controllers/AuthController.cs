﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Auth.Models;
using Common;
using Main.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Main.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IOptions<AuthOptions> authOptions;
        public AuthController(IOptions<AuthOptions> authOptions)
        {
            this.authOptions = authOptions;
        }

        private IList<Account> Accounts = new List<Account>()
        {
            new Account()
            {
                Id = Guid.NewGuid(),
                Email = "user@mail.ru",
                Password = "user",
                Roles = new Role[]{ Role.User}
            },
            new Account()
            {
                Id = Guid.NewGuid(),
                Email = "admin@mail.ru",
                Password = "admin",
                Roles = new Role[]{Role.Admin}
            }
        };

        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromBody] Login request)
        {
            var user = AuthenticateUser(request.Email, request.Pass);

            if (user != null)
            {
                var token = GenerateJWT(user);
                return Ok(new
                {
                    access_token = token
                });
            }
            return Unauthorized();

        }

        private Account AuthenticateUser(string email, string pass)
        {
            return Accounts.SingleOrDefault(u => u.Email == email && u.Password == pass);
        }


        private string GenerateJWT(Account user)
        {
            var authParams = authOptions.Value;
            var securityKey = authParams.GetSymetricSecurityKey();
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString())
            };

            foreach (var role in user.Roles)
            {
                claims.Add(new Claim("role", role.ToString()));
            }

            var token = new JwtSecurityToken(authParams.Issuer,
                authParams.Audience,
                claims,
                expires: DateTime.Now.AddSeconds(authParams.TokenLifeTime),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}