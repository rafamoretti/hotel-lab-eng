import React, {useState} from 'react'


function LoginForm({login, error}) {
    const[details, setDetails] = useState({email: "", password: ""});

    const submitHandler = e => {
        e.preventDefault();

        login(details);
    }

    return (
        <form onSubmit={submitHandler}>
            <div className="form-inner">
                <h2>Login</h2>
                {(error != "") ? (<div className="error">{error}</div>) : ""}
                <div className="form-group-email">
                    <input type="email" name="email" id="email" placeholder='E-mail' onChange={e => setDetails({...details, email: e.target.value})} value={details.email}/>
                </div>
                <div className="form-group-senha">
                    <input type="password" name="senha" id="senha" placeholder='Senha' onChange={e => setDetails({...details, password: e.target.value})} value={details.password} />
                </div>
                <input type="submit" value="Login" />
            </div>
        </form>
    )
}

export default LoginForm;
