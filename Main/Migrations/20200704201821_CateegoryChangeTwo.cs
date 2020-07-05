using Microsoft.EntityFrameworkCore.Migrations;

namespace Main.Migrations
{
    public partial class CateegoryChangeTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "parentId",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_parentId",
                table: "Category",
                column: "parentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_parentId",
                table: "Category",
                column: "parentId",
                principalTable: "Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_parentId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_parentId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "parentId",
                table: "Category");
        }
    }
}
