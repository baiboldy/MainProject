import React from 'react'
import Tab from 'components/tab/Tab'
import './container.css'
import Content from '../content/Content'

const  Container = () => {

    return (
        <div className="container">
            <Tab title='Категории'/>
            <Content/>
        </div>
    );
}

export default Container;