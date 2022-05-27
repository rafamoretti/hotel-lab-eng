import React from 'react'
import Barralateral from '../barra-lateral/Barralateral.js';
import "./checkin.css";

class Checkin extends React.Component{

  constructor (props) {
    super(props);
    this.state = {
      nome: "Nome",
      telefone: 999999999,
      email: "email@email.com",
      cpf: "99999999999",
      datacheckout: "01-01-2001",
      planos: "standard"
    };

    this.handleInputChange = this.handleInputChange.bind(this);
  }

  handleInputChange(event) {
    const target = event.target;
    const value = target.value;
    const name = target.name;

    this.setState({
      [name]: value
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
              <form>
                <div className="inner-form">
                  <div className="bloco1">
                    <p>Dados pessoais</p>
                    <input type="text" name="nome" id='nome' placeholder='Nome' value={this.state.value} onChange={this.handleChange}/>
                    <p></p>
                    <input type="tel" name="telefone" id="telefone" placeholder='Telefone' value={this.state.value} onChange={this.handleChange}/>
                    <p></p>
                    <input type="email" name="email" id="email" placeholder='Email' value={this.state.value} onChange={this.handleChange}/>
                    <p></p>
                    <input type="text" name="cpf" id="cpf" placeholder='CPF' value={this.state.value} onChange={this.handleChange}/>
                  </div>
                  <div className="bloco2">
                    <p>Data de check-out</p>
                    <input type="date" name="datacheckout" id="datacheckout" value={this.state.value} onChange={this.handleChange}/>
                    <p>Planos de hospedagem</p>
                    <select name="planos" id="planos" value={this.state.value} onChange={this.handleChange}>
                      <option value="standard">Standard</option>
                      <option value="premium">Premium</option>
                      <option value="fclass">Primeira classe</option>
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