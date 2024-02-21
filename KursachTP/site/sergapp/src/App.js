import './index.css';
import './App.css'
import { Link } from "react-router-dom";
import {FaGrinStars, FaBars, FaMoneyBillWave, FaHandPeace, FaTimes, FaFortAwesome, FaHeadset, FaVk, FaUser, FaYoutube,FaPhoneAlt, FaTelegram} from 'react-icons/fa';




function menuClick() {
  const links = document.getElementById("navbar");
  links.classList.toggle("showNav");
}
function CloseClick() {
  const links = document.getElementById("navbar");
  links.classList.toggle("showNav");
}

function App() {
  return (
<html>
    <body>
    
    <span className="nav-btn" id="nav-btn" onClick={menuClick}>
      <FaBars/>
    </span>
    <nav className="navbar" id="navbar">
<div className="navbar-header">
  <span className="nav-close" id="nav-close" onClick={CloseClick} >
    <FaTimes/>
  </span>
</div>
<ul className="nav-items">
  <li><a href="#home" className="nav-link">На главную</a></li>
  <li><a href="#about" className="nav-link">О нас</a></li>
  <li><a href="#team" className="nav-link">Сотрудники</a></li>
  <li><a href="#services" className="nav-link">Услуги</a></li>
  <li><a href="#contacts" className="nav-link">Напишите нам</a></li>
</ul>
    </nav>
   
    <header className="header" id='home'>
      <div className="banner">
        <h2>Sergbess</h2>
        <h1>
          Мы организуем концерты 
        </h1>
        <a href="#services" className="btn banner-btn">Узнать больше</a>
      </div>
    </header>
    
    <div className="content-divider"></div>
   
    <section className="skills clearfix">
      
      <article className="skill">
        <span className="skill-icon">
        <FaHandPeace />
        </span>
        <h4 className="skill-title">Качество</h4>
        <p className="skill-text">
          Со времён "Русского Вудстока" и до наших дней, компания Sergbess занимается организацией концертов и представлений. 
          За более чем 30 лет работы мы сделали возможными сотни выступлений различных артистов.
          Вы можете быть уверены в качестве наших услуг
        </p>
      </article>
      
      <article className="skill">
        <span className="skill-icon">
        <FaFortAwesome />
        
        </span>
        <h4 className="skill-title">Безопасность</h4>
        <p className="skill-text">
          Мы хорошо осведомлены о проблеме безопасности в вопросе организации массовых мероприятий, 
          поэтому гарантируем принятие всех  необходимых мер. Ваш концерт оставит только положительные эмоции
        </p>
      </article>
     
      <article className="skill">
        <span className="skill-icon">
          <FaMoneyBillWave/>
        </span>
        <h4 className="skill-title">Доступность</h4>
        <p className="skill-text">
          Несмотря на то, что для к нашей работы мы привлекаем только лучших специалистов, 
          услуги компании Serbess однозначно являются самыми доступными на рынке
        </p>
      </article>
      
      <article className="skill">
        <span className="skill-icon">
          <FaGrinStars/>
        </span>
        <h4 className="skill-title">Престиж</h4>
        <p className="skill-text">
          Работа с нами поставит вас в один ряд с лучшими группами последних сорока лет.
          Пользование услугами компании Serbess безусловно является показателем статуса и позволит вам попасть в среду самых популярных музыкантов современности 
          
        </p>
      </article>
     
      </section>
   
    <section id='about'>
      <div className="section-center clearfix">
   
      <article className="about-img">
        <div className="about-picture-container">
        <img src={require('./images/musical-group-rock-concert-a-crowd-of-people-at-a-concert-is-filming-a-video-on-their-phone_652844-616.jpg')} className="about-picture"/>
        </div>
      </article>
      
      <article className="about-info">
       
        <div className="section-title">
          <h3 className='regular'>Краткая история компании</h3>
          <h2>Sergbess</h2>
        </div>
        
        <p className="about-text">
          Всё стало возможным в 1986 году, после начала перестройки. 
          В условиях спадающих запретов мы решили заняться тем, чего хотели всегда - организовывать концерты. 
          Первым крупным шансом стал концерт в Лужниках в 1989 году,
           однако несмотря на наши старания и общий успех мероприятия, долгие годы после него было затишье, и мы едва оставались на плаву.
           Всё изменилось в 2003 году, когда в Москву приехал Пол Маккартни. Организация этого события изменила всё, такой опыт позволил занять нам господствующее положение на рынке.
        </p>
        <a ><Link to='/about'className='btn'>Узнать больше</Link> </a>
        </article>
        </div>
        </section>
    
    
    <section className="products" id='team'>
      <div className="section-center clearfix">
     
      <article className="products-info">
      
        <div className="section-title">
          <h3>Знакомьтесь</h3>
          <h2 className='regular'>Наша команда</h2>
        </div>
       
        <p className="product-text">
          Все наши успехи неслучайны - компания Sergbess стала такой благодаря людям, стоявших у её истоков.
          Руководство Сергея Дмитриевича, его умения найти нужные,самые добрые слова, технические и организационные таланты Костантина и Дмитрия -
          именно это позволило нам стать собой. Основу Sergbess составляют 10 сотрудников, ниже вы можете ознакомиться со всеми.
        </p>
        <a href="products.html" ><Link to='/workers'className='btn'>Ознакомиться</Link></a>
      </article>
      
      <article className="products-inventory clearfix">
        
        <div className="product serg">
        <img src={require('./images/photo_5310269119662245859_y.jpg')} className="product-img"/>
          <h4 className="product-title">Сергей Шандала</h4>
          <h4 className="product-price">Основатель</h4>
        </div>
        <div className="product">
        <img src={require('./images/653f744a-aee6-4515-aafe-d803b4226ce8.jpg')} className="product-img"/>
          <h4 className="product-title">Костантин Роков</h4>
          <h4 className="product-price">Специалист по безопасности</h4>
        </div>
        
        <div className="product">
        
        <img src={require('./images/715ebe67-b5a4-40d6-9bd6-ff6e263385f6.jpg')} className="product-img"/>

          <h4 className="product-title">Дмитрий Артистов</h4>
          <h4 className="product-price">Технический райдер</h4>
        </div>
        
      </article>
      </div>
    </section>
   
    <div className="services" id='services'> 
      
        <div className="section-title services-title">
          <h3>Ознакомьтесь</h3>
          <h2>с нашими услугами</h2>
        </div>
       
        <div className=" section-center clearfix">
         
          <article className="service-card">
          
            <div className="service-img-container">

            <img src={require('./images/ZAWFfTQKhSA.jpg')} className="service-img"/>

<span className="service-icon">
  <FaUser/>
</span>
            </div>
           
            <div className="service-info">
              <h4>Организация концерта</h4>
              <p>Организуем ваш концерт, обеспечив полный комплект услуг, сопровождая вас на всём протяжении процесса</p>
              <a><Link to='/middle' className='btn service-btn'>Подробнее</Link></a>
            </div>
          </article>
         
          <article className="service-card">
            
            <div className="service-img-container">

            <img src={require('./images/11062b_c2e6a0a1542d41b5aab58d03b0b6af85~mv2 (2).jpg')} className="service-img"/>
           
<span className="service-icon">
  <FaHeadset/>
</span>
            </div>
            
            <div className="service-info">
              <h4>Консультация</h4>
              <p>Проинструктируем вас как собственными силами организовать концерт, если у вас есть всё необходимое </p>
              <a href="#contacts" className="btn service-btn" >Подробнее</a>
            </div>
          </article>
          
        
          
        </div>
        </div>
    
    <section className="contact">
      <div className="section-center clearfix">

<article className="contact-info">
  
  <div className="contact-item">
    <h4 className="contact-title">
      <span className="contact-icon">
        <i className="fas fa-location-arrow" ></i>
      </span>
      Адрес
    </h4>
    <h4 className="contact-text">
 308 Negra Aroya Lane <br/> Albuquerque, New Mexico, 87104.
    </h4>
  </div>
 
  <div className="contact-item">
    <h4 className="contact-title">
      <span className="contact-icon">
        <i className="fas fa-envelope" ></i>
      </span>
      Почта
    </h4>
    <h4 className="contact-text">
email@email.com
    </h4>
  </div>
  
  <div className="contact-item">
    <h4 className="contact-title">
      <span className="contact-icon">
        <i className="fas fa-phone"></i>
      </span>
      Телефон
    </h4>
    <h4 className="contact-text">
      + 8 800 555 35 35
    </h4>
  </div>
 
</article>

<article className="contact-form" id='contacts'>
  <h3 >Свяжитесь с нами</h3>
  <form action="https://formspree.io/f/xjvzkpqy" method="POST">
    <div className="form-group">
      <input type="text" placeholder="Ваше имя" className="form-control" name="name"></input>
      <input type="email" placeholder="Ваша почта" className="form-control" name="name"></input>
      <textarea name="message"  placeholder="Суть вопроса"   rows="5" className="form-control"></textarea>
    </div>
    
    <button type="submit" className="submit-btn btn">Подтвердить</button>
  </form>
</article>
      </div>
    </section>
    
    <footer className="footer">
      <div className="section-center">
        <div className="social-icons">
        
          <a href="#" className="social-icon">
            <FaYoutube/>
          </a>
         
          <a href="#" className="social-icon">
            <FaVk/>
          </a>
          
          <a href="#" className="social-icon">
            <FaTelegram/>
          </a>
          
        </div>
        <h4 className="footer-text">
          &copy; <span id="date" >2023</span>
          <span className="company">Sergbess</span>
          Все права защищены
        </h4>
      </div>
    </footer>
    <script src="app.js"></script>
  </body>
  </html>

  );
}

export default App;
