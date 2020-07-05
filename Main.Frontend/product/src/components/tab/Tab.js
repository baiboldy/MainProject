import React, { useState, useEffect } from 'react'
import './tab.css'
import List from 'components/list/List'
import { connect } from 'react-redux';
import { getCategory } from 'actions/category'

const Tab = props => {
    const [isOpen, setIsOpen] = useState(false);
    const {
        title,
        data,
        onInitCategory
    } = props;
    const onTabClick = event => {
        setIsOpen(!isOpen)
    } 

    useEffect(() => {
        onInitCategory()
    }, [onInitCategory])

    return (
        <div onClick={onTabClick} className='tab'>
            <div className="tab_container">
                <div className="tab_title">{title}</div>
                <button className="tab_button">&#8659;</button>
            </div>
            {isOpen && <List data={data} type='row'/>}
        </div>
    );
}

export default  connect(
    state => ({
        data: state.category
    }),
    dispatch => ({
      onInitCategory: () => {
        dispatch(getCategory())
      }  
    })
    )(Tab);