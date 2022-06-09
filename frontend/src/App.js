import React, {useState} from 'react';
import LoginForm from './components/LoginForm';
import Slider from './components/Slider/Slider';
import Modal from './components/Modal/Modal';
import Home from './components/Home/Home';
import Checkin from './components/Checkin/Checkin';
import Checkout from './components/Checkout/Checkout';
import "./app.css";
import { BrowserRouter as Router, Route, Routes, Switch } from 'react-router-dom';

function App() {
  const adminUser = {
    email: "admin@admin.com",
    password: "admin123"
  }

  const [user, setUser] = useState({email: "admin@admin.com", password: "admin123"});
  const [error, setError] = useState("");

  const login = details => {
    console.log(details);

    if (details.email == adminUser.email && details.password == adminUser.password){
      console.log("Sextou");
      setUser({email: details.email});
    } else {
      console.log("Deu não");
      setError("Dados incorretos");
    }
  }
  const logout = () =>{
    setUser({email: ""});
  }

  return (
    <Router>
      <div className="App">
        {(user.email != "") ? (
          <div className="welcome">
            <Routes>
              <Route path="/" element={<Home />} />
              <Route path="/checkin" element={<Checkin />} />
              <Route path="/checkout" element={<Checkout />} />
            </Routes>
            <button className='logout' onClick={logout}>Logout</button>
          </div>
        ) : (
          
          <div>
            <LoginForm login={login} error={error} /> 
          </div>
        )}
        <>
          <Slider />
        </>
        <>
          <Modal />
        </>
      </div>
    </Router>
  );
}

export default App;


/*<button onClick={logout}>Logout</button>*/