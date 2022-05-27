import React from 'react'
import Barralateral from '../barra-lateral/Barralateral.js';
import "./checkout.css";

function Checkout() {
  return (
    <div className="checkout">
        <>
            <Barralateral />
        </>
        <div className="checkout-form">
            <h2>Check-out</h2>
            <div className="comanda">
                <p>Consumo</p>
                <ul>
                    <li>Produto 1 &emsp; R$</li>
                    <li>Produto 2 &emsp; R$</li>
                    <li>Produto 3 &emsp; R$</li>
                </ul>
                <p>_________________________</p>
                <b>Total:</b>
                <label id="total">$RS</label>
            </div>
            <div className="renova">
                <p>Renovar Check-in</p>
                <input type="date" name="datacheckout" id="datacheckout" />
                <p></p>
                <button id="renovar">Renovar</button>
            </div>
            <button id="concluir">Concluir Check-out</button>
        </div>
    </div>
  )
}

export default Checkout