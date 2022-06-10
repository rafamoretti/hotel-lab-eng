import React, {useState} from 'react'
import Barralateral from '../barra-lateral/Barralateral.js';
import "./checkin.css";
import api from "../../services/api"

class Checkin extends React.Component{

  constructor (props) {
    super(props);
  }

  handleInputChange(event) {
    event.preventDefault();
    let nome = event.target.nome.value;
    let telefone = event.target.telefone.value;
    let email = event.target.email.value;
    let cpf = event.target.cpf.value;
    let datacheckout = event.target.datacheckout.value;
    let planos = event.target.planos.value;
    
   
    const config = {
      method: "POST", 
      headers: {
        'Accept': 'application/json, text/plain, */*',
        'Content-Type': 'application/json',
        'Access-Control-Allow-Origin': "*",
        'Access-Control-Allow-Headers': "*"
      },
      body: JSON.stringify  ({ 
        enddate: datacheckout,
        type: planos,
        guest: {
          name: nome,
          email: email,
          phone: telefone,
          cpf: cpf
        }
      }), mode: 'cors',
      referrer: "about:client",
      referrerPolicy: "no-referrer-when-downgrade", 
    };
    fetch("https://localhost:5001/v1/checkin", config)
      .then(function (response) {
        console.log(response.status);
        console.log("agrnalnhbnlfuenjagnawjngjunlwgçne");
      });

    
  }

  render() {
    return (
      <div className="Checkin">
          <>
              <Barralateral />
          </>
          <div className="checkin-form">
              <h2>Check-in</h2>
              <form onSubmit={this.handleInputChange}>
                <div className="inner-form">
                  <div className="bloco1">
                    <p>Dados pessoais</p>
                    <input type="text" name="nome" id='nome' placeholder='Nome' onChange={this.handleChange}/>
                    <p></p>
                    <input type="tel" name="telefone" id="telefone" placeholder='Telefone' onChange={this.handleChange}/>
                    <p></p>
                    <input type="email" name="email" id="email" placeholder='Email' onChange={this.handleChange}/>
                    <p></p>
                    <input type="text" name="cpf" id="cpf" placeholder='CPF' onChange={this.handleChange}/>
                  </div>
                  <div className="bloco2">
                    <p>Data de check-out</p>
                    <input type="date" name="datacheckout" id="datacheckout" onChange={this.handleChange}/>
                    <p>Planos de hospedagem</p>
                    <select name="planos" id="planos" onChange={this.handleChange}>
                      <option value={0}>Standard</option>
                      <option value={1}>Premium</option>
                      <option value={2}>Primeira classe</option>
                    </select>
                    <p></p>
                    <input type="submit" value="Confirmar" />
                  </div>
                </div>
                <div className="numero">
                  Quartos:
                  <label id='num'>101</label>
                </div>
              </form>
          </div>
      </div>
    )
  }
}
export default Checkin