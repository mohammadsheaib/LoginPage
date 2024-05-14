import { useState } from 'react';
import './login.css'; // Import CSS file

function Login() {
    const [Username, setUsername] = useState('');
    const [Password, setPassword] = useState('');
    const [message, setMessage] = useState('');

    const handleSubmit = async (e) => {
        e.preventDefault();
        const response = await fetch('http://localhost:5237/api/authentication/login', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ Username, Password }),
        });
        const data = await response.json();
        setMessage(data.message);
    };

    return (
        <div className="login-container">
            <h1 className="login-title">Login</h1>
            <form className="login-form" onSubmit={handleSubmit}>
                <input type="text" placeholder="Username" value={Username} onChange={(e) => setUsername(e.target.value)} />
                <input type="password" placeholder="Password" value={Password} onChange={(e) => setPassword(e.target.value)} />
                <button type="submit">Login</button>
            </form>
            {message && <p className={`login-message ${message === 'Invalid credentials.' ? 'invalid-message' : 'success-message'}`}>{message}</p>}
        </div>
    );
}

export default Login;
