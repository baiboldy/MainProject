import React from 'react';
import List from 'components/list/List';
import { connect } from 'react-redux';
import './content.css'

const Content = props => {

    const { data } = props;

    return (
        <div className="content">
            <List data={data} type='card'/>
        </div>
    );
};

export default connect(
    state => ({
        data: state.product
    })
)(Content);