import React, { useEffect, useState } from 'react'
import api from "../services/api"

function LoginForm({ login, error }) {
    const [email, setemail] = useState("");
    const [senha, setsenha] = useState("");

    /*const submitHandler = e => {
        e.preventDefault();

        login(details);
    }  */

    const data = {
        "email":email, "password":senha
    };

    const config = {
        method:"GET", 
        params:JSON.stringify({
            email:email, password:senha
        }),  
        
    };

    function submitHandler(e) {
        e.preventDefault();
        fetch ("employee/auth", config)
            .then (function(response){
                console.log(data);
                console.log(response.status);
                console.log("agrnalnhbnlfuenjagnawjngjunlwgçne");
                login(response)
            })

    };



    return (
        <form onSubmit={submitHandler}>
            <div className="form-inner">
                <h2>Login</h2>
                {(error != "") ? (<div className="error">{error}</div>) : ""}
                <div className="form-group-email">
                    <input type="email" name="email" id="email" placeholder='E-mail' onChange={e => setemail(e.target.value)} />
                </div>
                <div className="form-group-senha">
                    <input type="password" name="senha" id="senha" placeholder='Senha' onChange={e => setsenha(e.target.value)} />
                </div>
                <input type="submit" value="Login" />
            </div>
        </form>
    )
}

export default LoginForm;
