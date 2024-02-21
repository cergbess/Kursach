import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import {FaGrinStars, FaBars, FaMoneyBillWave, FaHandPeace, FaTimes, FaFortAwesome, FaHeadset, FaVk, FaUser, FaYoutube,FaPhoneAlt, FaTelegram} from 'react-icons/fa';

const handleSubmit = (event) => {
  event.preventDefault();
  alert(`Ваша заявка отправлена на рассмотрение `)
}
function FormPage() {
    return (
        <body>
        <section className="contact2">
        <div className="section-center clearfix">
  
 
  
  <article className="contact-forma" id='contacts'>
    <h3 >Уточним данные</h3>
    <form action="https://formspree.io/f/xjvzkpqy" method="POST" onSubmit={handleSubmit}>
      <div className="form-group">
        <input type="text" placeholder="название концерта" className="form-control" name="name"></input>
        <input type="text" placeholder="стоимость билетов" className="form-control" name="name"></input>
        <input type="text" placeholder="количество зрителей" className="form-control" name="name"></input>
        <input type="text" placeholder="номер артиста" className="form-control" name="name"></input>
        <input type="text" placeholder="номер сцены" className="form-control" name="name"></input>
        <p className='form-date'>Дата концерта</p>
        <input type="date" placeholder="Дата проведения" className="form-control" name="name"></input>
      </div>
      
      <button type="submit" className="submit-btn btn">Подтвердить</button>
    </form>
  </article>
  <a><Link to='/' className='btn form-back'>Вернуться на главную</Link> </a>
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


export default FormPage;