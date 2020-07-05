const initState = [
    {
        id: 555,
        title: 'Iphone XS',
        price: 5500,
        description: 'cool phone',
        img: ''
    },
    
    {
        id: 444,
        title: 'Iphone XS Max',
        price: 6500,
        description: 'cool phone +',
        img: ''
    }
];

export default (state = initState, action) => {
    if (action.type === 'GET_DATA') {
        return state;
    }
    return state;
}