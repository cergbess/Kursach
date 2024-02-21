import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import {
  createBrowserRouter,
  RouterProvider,
} from "react-router-dom";
import AboutPage from './AboutPage';
import FormPage from './FormPage';
import PersonalPage from './PersonalPage';
import MiddlePage from './MiddlePage';
import DeletePage from './DeletePage';

const router = createBrowserRouter([
  {
    path: "/",
    element: <App/>,
  },
  {
    path: "about",
    element: <AboutPage/>,
  },
  {
    path: "for",
    element: <FormPage/>,
  },
  {
    path: "workers",
    element: <PersonalPage/>,
  },
  {
    path: "middle",
    element: <MiddlePage/>,
  },
  {
    path: "delete",
    element: <DeletePage/>,
  },
]);


const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
      <RouterProvider router={router} />
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
