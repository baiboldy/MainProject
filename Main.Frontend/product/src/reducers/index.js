import { combineReducers } from 'redux';
import category from 'reducers/category';
import product from 'reducers/product';

export default combineReducers({
    category,
    product
})