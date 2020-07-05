export const getCategory = () => async dispatch => {
    const result = await fetch('https://localhost:5555/api/Category/GetCategories', {
        method: 'get',
    })
    const { data } = await result.json()
    dispatch({type: 'INIT_CATEGORY', payload: data})
}