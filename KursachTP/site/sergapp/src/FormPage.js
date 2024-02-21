import React, { useState } from 'react';
import { FaVk, FaYoutube, FaTelegram } from 'react-icons/fa';

function FormPage() {
  const [formValues, setFormValues] = useState({
    ConcertTitle: '',
    TicketPrice: '',
    NumberOfViewers: '',
    ArtistId: '',
    SceneId: '',
    DateOfEvent: ''
  });

  const handleSubmit = async (event) => {
    event.preventDefault();
    await fetch('/api/Domain/Concert/Add', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(formValues)
    })
      .then((response) => {
        if (response.ok) {
          alert('Ваша заявка отправлена на рассмотрение');
        } else {
          throw new Error('Ошибка HTTP: ' + response.status);
        }
      })
      .catch((error) => {
        console.log(error);
      });
  };

  const handleChange = (event) => {
    const { name, value } = event.target;
    setFormValues((prevState) => ({
      ...prevState,
      [name]: value
    }));
  };

  return (
    <body>
      <section className="contact2">
        <div className="section-center clearfix">
          <article className="contact-forma" id="contacts">
            <h3>Уточним данные</h3>
            <form onSubmit={handleSubmit}>
              <div className="form-group">
                <input type="text" placeholder="название концерта" className="form-control" value={formValues.ConcertTitle} name="ConcertTitle" onChange={handleChange}></input>
                <input type="text" placeholder="стоимость билетов" className="form-control" value={formValues.TicketPrice} name="TicketPrice" onChange={handleChange}></input>
                <input type="text" placeholder="количество зрителей" className="form-control" value={formValues.NumberOfViewers} name="NumberOfViewers" onChange={handleChange}></input>
                <input type="text" placeholder="номер артиста" className="form-control" value={formValues.ArtistId} name="ArtistId" onChange={handleChange}></input>
                <input type="text" placeholder="номер сцены" className="form-control" value={formValues.SceneId} name="SceneId" onChange={handleChange}></input>
                <p className="form-date">Дата концерта</p>
                <input type="date" placeholder="Дата проведения" className="form-control" value={formValues.DateOfEvent} name="DateOfEvent" onChange={handleChange}></input>
              </div>
              <button type="submit" className="submit-btn btn">Подтвердить</button>
            </form>
          </article>
          <a href="/">
            <button className="btn form-back">Вернуться на главную</button>
          </a>
        </div>
      </section>
      <footer className="footer">
        <div className="section-center-form">
          <div className="social-icons">
            <a href="#" className="social-icon">
              <FaVk />
            </a>
            <a href="#" className="social-icon">
              <FaYoutube />
            </a>
            <a href="#" className="social-icon">
              <FaTelegram />
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