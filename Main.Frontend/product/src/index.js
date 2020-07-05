import React from 'react';
import { render } from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';
import { Provider } from 'react-redux';
import { createStore, applyMiddleware } from 'redux';
import redcuers from 'reducers';
import thunk from 'redux-thunk';
import { composeWithDevTools } from 'redux-devtools-extension';

const store = createStore(redcuers, composeWithDevTools(applyMiddleware(thunk)));

render(
  <Provider store={store}>
    <React.StrictMode>
      <App />
    </React.StrictMode>
  </Provider>,
  document.getElementById('root')
);

serviceWorker.unregister();
