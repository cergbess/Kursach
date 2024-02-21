import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import {FaGrinStars, FaBars, FaMoneyBillWave, FaHandPeace, FaTimes, FaFortAwesome, FaHeadset, FaVk, FaUser, FaYoutube,FaPhoneAlt, FaTelegram} from 'react-icons/fa';


function Workers() {
    return (
        <body>
        <section className="contact3">
        <div className="section-center clearfix">
  
 
  {/* <h1 className='personal-header' >Лучшие ищ лучших</h1> */}
  <h1 className='personal-header' >Наш коллектив</h1>
        <article className="products-inventory-workers clearfix">
        
        <div className="product-workers serg">
        <img src={require('./images/photo_5310269119662245859_y.jpg')} className="product-img"/>
          <h4 className="product-title">Сергей <br/>Шандала</h4>
          <h4 className="product-price regular">Отец основатель</h4>
        </div>
        <div className="product-workers">
        <img src={require('./images/653f744a-aee6-4515-aafe-d803b4226ce8.jpg')} className="product-img"/>
          <h4 className="product-title">Костантин <br/>Роков</h4>
          <h4 className="product-price regular">Глава бухгалтерии</h4>
        </div>
        
        <div className="product-workers">
        
        <img src={require('./images/715ebe67-b5a4-40d6-9bd6-ff6e263385f6.jpg')} className="product-img"/>

          <h4 className="product-title">Дмитрий Артистов</h4>
          <h4 className="product-price regular">Технический райдер</h4>
        </div>
        <div className="product-workers">
        
        <img src={require('./images/maxresdefault.jpg')} className="product-img"/>

          <h4 className="product-title">Боромир <br/>Клинтов</h4>
          <h4 className="product-price regular">Глава пиар отдела</h4>
        </div>
        <div className="product-workers">
        
        <img src={require('./images/Kurt-Cobain-Nirvana-1993.webp')} className="product-img"/>

          <h4 className="product-title">Евгений <br/>Нерванов</h4>
          <h4 className="product-price regular">Менеджер артистов</h4>
        </div>
        
      </article>
        <article className="products-inventory-workers clearfix">
        
        <div className="product-workers serg">
        <img src={require('./images/480x497_0xac120003_2925960751567524438.jpg')} className="product-img"/>
          <h4 className="product-title">Фёдор <br/>Меркуров</h4>
          <h4 className="product-price regular">Ответственный за сцену</h4>
        </div>
        <div className="product-workers">
        <img src={require('./images/280x420.webp')} className="product-img"/>
          <h4 className="product-title">Дарослав <br/>Леннин</h4>
          <h4 className="product-price regular">Специалист по безопасности</h4>
        </div>
        
        <div className="product-workers">
        
        <img src={require('./images/luke-skywalker-mark-hamill-star-wars-force-awakenjpeg-600x400.jpeg')} className="product-img"/>

          <h4 className="product-title">Любомысл Небоходин</h4>
          <h4 className="product-price regular">Отвественный за персонал</h4>
        </div>
        <div className="product-workers">
        
        <img src={require('./images/batmanbegins_78042.jpg')} className="product-img"/>

          <h4 className="product-title">Климентий Бейлин</h4>
          <h4 className="product-price regular">Специалист по гриму</h4>
        </div>
        <div className="product-workers">
        
        <img src={require('./images/rw.jpg')} className="product-img"/>

          <h4 className="product-title">Ростислав <br/>Уоллов</h4>
          <h4 className="product-price regular">Ответственный за музыку</h4>
        </div>
        
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


export default Workers;