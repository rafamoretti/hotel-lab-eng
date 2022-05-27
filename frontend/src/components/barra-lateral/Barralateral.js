import React from 'react'
import { Link } from 'react-router-dom';
import "./barralateral.css";

export default function Barralateral() {
  return (
    <div className="barra-lateral">
        <Link to="/" className="bnt-home">Home</Link>
        <p></p>
        <Link to="/checkin" className="bnt-checkin">Check-In</Link>
    </div>
  )
}

