import React, { useState } from "react";
import "./Modal.css";

export default function Modal() {
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
      <button onClick={toggleModal} className="btn-modal">
        Não possui conta?
      </button>

      {modal && (
        <div className="modal">
          <div onClick={toggleModal} className="overlay"></div>
          <div className="modal-content">
            <h2>Registrar-se</h2>
                <div className="registro-email">
                    <input type="email" name="email" id="email" placeholder='E-mail'/>
                    <p></p>
                </div>
                <div className="registro-senha">
                    <input type="password" name="senha" id="senha" placeholder='Senha'/>
                    <p></p>
                </div>
                <div className="registro-hotel">
                    <input type="name" name="hotel" id="hotel" placeholder='Hotel'/>
                    <p></p>
                </div>
            <button className="close-modal" onClick={toggleModal}>
              Registrar
            </button>
          </div>
        </div>
      )}
      <p></p>
    </>
  );
}
