import React, { useState } from 'react';
import { FaVk, FaYoutube, FaTelegram } from 'react-icons/fa';

function DeletePage() {
  const [formValues, setFormValues] = useState({
    ConcertId: '',
  });

  const handleSubmit = async (event) => {
    event.preventDefault();
    const response = await fetch('/api/Domain/Concert/Delete', {
      method: 'DELETE',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(formValues),
    });
    if (response.ok) {
      setFormValues({ ConcertId: '' });
      alert('Концерт успешно удален!');
    } else {
      alert('Ошибка при удалении концерта!');
    }
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
            <h3>Номер концерта для удаления</h3>
            <form onSubmit={handleSubmit}>
              <div className="form-group">
                <input type="text" placeholder="номер концерта" className="form-control" value={formValues.ConcertId} name="ConcertId" onChange={handleChange}></input>
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

export default DeletePage;