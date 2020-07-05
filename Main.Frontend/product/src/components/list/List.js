import React from 'react'
import './list.css'
import ComponentType from '../componentType/ComponentType';

const List = props => {
    const {
        data,
        type
    } = props;
    return (
        <div className="list">
            {/* {data.map((row, id) => <Row key={id} data={row} type='card'/> )} */}
            {data.map((row, id) => <ComponentType key={id} data={row} type={type}/> )}
        </div>
    );
}

export default List;