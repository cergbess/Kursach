import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import {FaGrinStars, FaBars, FaMoneyBillWave, FaHandPeace, FaTimes, FaFortAwesome, FaHeadset, FaVk, FaUser, FaYoutube,FaPhoneAlt, FaTelegram} from 'react-icons/fa';
import axios from "axios";
import { useEffect, useState } from "react";


function menuClick() {
    const links = document.getElementById("nav-links-middle");
    links.classList.toggle("show-links-middle");
  }
function menuClick2() {
    const links = document.getElementById("nav-links-middle2");
    links.classList.toggle("show-links-middle2");
  }
function menuClick3() {
    const links = document.getElementById("middle-btn-main");
    links.classList.toggle("hide-middle-btn-main");
    
  }
function menuClick4() {
    const links = document.getElementById("middle-btn-main");
    links.classList.toggle("show-middle-btn-main");
  }

function MiddlePage() {
  
  const [data, setData] = useState([]);

  const [name,setName] = useState('')
  const [name1,setName1] = useState('')
  const [tempValue, setTempValue] = useState('');

    
  const handleButtonClick = () => {
  setTempValue(name);
  };
  
  const params = {
  ConcertTitle: name
  };
  
  const queryString = params
  ? Object.keys(params)
  .map((key) => `${encodeURIComponent(key)}=${encodeURIComponent(params[key])}`)
  .join('&')
  : '';
  
  const baseUrl = '/api/Domain/Concert/ConcertTitle';
  
  const url = queryString ? `${baseUrl}?${queryString}` : baseUrl;
  
  useEffect(() => {
  const fetchData = async() => {
  const response = await axios.get(url)
  
  setData(response.data)
  }
  fetchData()
    }, [name]);
    return (
        <body>
            

        <section className="contact4">
        <div className="section-center clearfix">
  
 
  
  <article className="main-container" id='contacts'>
  {/* <a><Link to='/middle' className='btn middle-btn middle-btn-main' id='middle-btn-main' onClick={menuClick3}>Вывести концерты</Link></a> */}
  {/* <a><Link to='/middle' className='btn middle-btn middle-btn-main2' id='middle-btn-main2' onClick={menuClick4}>Скрыть</Link></a>   */}
  <div className='get-table'>
      <h1 className='regular'>Список концертов:</h1>
      <div >
        <div className='table-head'>
        <th>ConcertId</th>
            {/* <th>ConcertId</th> */}
            <th>ArtistId</th>
            <th>SceneId</th>
            <th>ConcertTitle</th>
            <th>DateOfEvent</th>
            <th>TicketPrice</th>
            <th>Viewers</th>
            
            
          
        </div>
        <tbody>
          {data.map((post) => {
            return (
              <div className='table-head2'>
                <td style={{ color: "----clr-grey-8" }}>{post.concertId}</td>
                {/* <td>{post.concertId}</td> */}
                <td>{post.artistId}</td>
                <td>{post.sceneId}</td>
                <td>{post.concertTitle}</td>
                <td>{post.dateOfEvent}</td>
                <td>{post.ticketPrice}</td>
                <td>{post.numberOfViewers}</td>
              </div>
            );
          })}
        </tbody>
      </div>
    

      </div>
  </article>
  <div className='buttons'>
  <a><Link to='/middle' className='btn middle-btn first-middle' id="nav-toggle" onClick={menuClick}>Сортировать</Link>
  <ul className="nav-links-middle" id="nav-links-middle">
            <li>
            <div className="nav-link-middle scroll-link">
              <a href="#home" className="midlli scroll-link">По названию</a>
              <input
          type="text" 
          placeholder="Ввести название концерта" 
          style={{width:110,marginTop:5}} 
          value={name}
          onChange={event => setName(event.target.value)}
          // className='form-control-3'
        />
              </div>
            </li>
            <li>
              <a href="#about" className="nav-link-middle scroll-link">По номеру</a>
            </li>
            <li>
              <a href="#services" className="nav-link-middle scroll-link">По артисту</a>
            </li>            
            <li>
              <a href="#featured" className="nav-link-middle scroll-link">По сцене</a>
            </li>
            <li>
              <a href="#featured" className="nav-link-middle scroll-link">По концерту</a>
            </li>
          </ul>
  </a>
  
  <a><Link to='/for' className='btn middle-btn'>Добавить</Link></a>
  <a><Link to='/delete' className='btn middle-btn'>Удалить</Link></a>
  </div>
  <a><Link to='/' className='btn form-back2'>Вернуться на главную</Link> </a>
        </div>
      </section>
      
      <footer className="footer">
      <div className="section-center-form">
        <div className="social-icons">
         
          <a href="#" className="social-icon">
          <FaVk/>
          </a>
          
          <a href="#" className="social-icon">
          <FaYoutube/>
          </a>
          
          <a href="#" className="social-icon">
          <FaTelegram/>
          </a>
          
        </div>
        <h4 className="footer-text">
          &copy; <span id="date">2023</span>
          <span className="company">Sergbess</span>
         Все права защищены
        </h4>
      </div>
    </footer>
    </body>
        );
    }


export default MiddlePage;