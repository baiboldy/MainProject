const initState = [
    {
        id: 111,
        title: 'Телефоны',
        data: [
            {
                id: 123,
                title: 'Iphone',
            },
            {
                id: 222,
                title: 'Samsung'
            }
        ],
    },
    {
        id: 123123,
        title: 'Автомобили'
    },
    {
        id: 123123,
        title: 'Услуги'
    },
    {
        id: 123123,
        title: 'Техника'
    },
    {
        id: 123123,
        title: 'Спорт'
    },
    {
        id: 123123,
        title: 'Одежда'
    },
  ];
export default (state = initState, action) => {
    if (action.type === 'INIT_CATEGORY') {
      return action.payload
    }
    return state;
}