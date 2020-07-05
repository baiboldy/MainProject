import React, {useState} from 'react'
import './row.css'
import List from 'components/list/List';

const Row = props => {
    debugger;
    const {
        data: {
            title,
            subCategories
        }
    } = props;
    
    const [isOpen, setIsOpen] = useState(false);

    const onRowClick = event => {
        event.stopPropagation();
        setIsOpen(!isOpen)
    }
    const haveChildren = subCategories && subCategories.length > 0

    return (
        <div className='row' onClick={onRowClick}>
            <div className="row_container">
                <div className="tab_title">{title}</div>
                {haveChildren && <button className="tab_button">&#8659;</button>}
            </div>
            {haveChildren && isOpen && <List data={subCategories} type='row'/>}
        </div>
    );
};

export default Row;