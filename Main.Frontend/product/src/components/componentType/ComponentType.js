import React from 'react';
import Card from 'components/card/Card';
import Row from 'components/row/Row';

const ComponentType = props => {
    const { 
        data,
        type
     } = props;
    const componentType = {
        'card': Card,
        'row': Row,
    }
    debugger;
    const component = componentType[type]

    return (
        component({data: data})
    )
}

export default ComponentType;