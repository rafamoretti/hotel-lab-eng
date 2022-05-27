import React, { useState } from 'react';
import "./home.css";
import Barralateral from '../barra-lateral/Barralateral.js';
import { Link } from 'react-router-dom';

export default function Home() {

  const [modal, setModal] = useState(false);

  const toggleModal = () => {
    setModal(!modal);
  };

  if(modal) {
    document.body.classList.add('active-modal')
  } else {
    document.body.classList.remove('active-modal')
  }

  return (
    <>
      <div className='Home'>
        <>
          <Barralateral />
        </>
        <div className="quartos">
            <h2>Quartos</h2>
            <div className="q101">
              <button className="btn-num" onClick={toggleModal}>101</button>
              <span className="marker"></span>
            </div>
            <div className="q102">
              <button className="btn-num" onClick={toggleModal}>102</button>
              <span className="marker"></span>
            </div>
            <div className="q103">
              <button className="btn-num" onClick={toggleModal}>103</button>
              <span className="marker"></span>
            </div>
            <div className="q104">
              <button className="btn-num" onClick={toggleModal}>104</button>
              <span className="marker"></span>
            </div>
            <div className="q105">
              <button className="btn-num" onClick={toggleModal}>105</button>
              <span className="marker"></span>
            </div>
            <div className="q106">
              <button className="btn-num" onClick={toggleModal}>106</button>
              <span className="marker"></span>
            </div>
            <div className="q107">
              <button className="btn-num" onClick={toggleModal}>107</button>
              <span className="marker"></span>
            </div>
            <div className="q108">
              <button className="btn-num" onClick={toggleModal}>108</button>
              <span className="marker"></span>
            </div>
            <div className="q109">
              <button className="btn-num" onClick={toggleModal}>109</button>
              <span className="marker"></span>
            </div>
            <div className="q110">
              <button className="btn-num" onClick={toggleModal}>110</button>
              <span className="marker"></span>
            </div>
            <div className="q110">
              <button className="btn-num" onClick={toggleModal}>110</button>
              <span className="marker"></span>
            </div>
            <div className="q111">
              <button className="btn-num" onClick={toggleModal}>111</button>
              <span className="marker"></span>
            </div>
            <div className="q112">
              <button className="btn-num" onClick={toggleModal}>112</button>
              <span className="marker"></span>
            </div>
            <div className="q113">
              <button className="btn-num" onClick={toggleModal}>113</button>
              <span className="marker"></span>
            </div>
            <div className="q114">
              <button className="btn-num" onClick={toggleModal}>114</button>
              <span className="marker"></span>
            </div>
            <div className="q115">
              <button className="btn-num" onClick={toggleModal}>115</button>
              <span className="marker"></span>
            </div>
        </div>
      </div>

      {modal && (
        <div className="modal">
          <div onClick={toggleModal} className="overlay"></div>
          <div className="modal-content">
            <h2>Quarto - 101</h2>
            <small>Hóspede</small>
            <br /><label id="hospede">Rafael Moretti</label>
            <br /><small>Telefone</small>
            <br /><label id="telefone">0800 0420-6969</label>
            <p></p>
            <small>Adcionar consumo</small>
            <br /><select name="produto" id="produto">
              <option value="produto1">Produto</option>
              <option value="produto2">Produto 2</option>
              <option value="produto3">Produto 3</option>
            </select>
            <label id="valor">Valor</label>
            <p></p>
            <button id="adicionar" className='btn' onClick={toggleModal}>Adicionar</button>
            <p></p>
            <small>Ocupação</small>
            <br /><select name="ocupacao" id="ocupacao">
              <option value="disponivel">Disponivel</option>
              <option value="ocupado">Ocupado</option>
              <option value="desocupado">Desocupado</option>
              <option value="limpo">Limpo</option>
            </select>
            <p></p>
            <br /><Link to="/checkout" id="btn-checkout" className='btn'>Realizar Check-out</Link>
          </div>
        </div>
      )}
    </>
  );

}


