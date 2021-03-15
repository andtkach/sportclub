import React, { useContext } from "react";
import { AuthContext } from "../../context";

import { useForm } from "../../hooks/useForm";

import { authenticate as apiAuthenticate } from "../../services/account";

export const LoginForm = () => {
  const authContext = useContext(AuthContext);

  const [loginForm, change, resetLoginForm] = useForm({
    email: "john.doe@email.com",
    password: "P@assw0rd1",
  });

  const loginHandler = () => {
    apiAuthenticate(loginForm).then((data) => {
      authContext.login(data.token);
      resetLoginForm();
    });
  };

  const logoutHandler = () => {
    authContext.logout();
  };

  return (
    <>
      {!authContext.isLoggedIn && (
        <form>
          <h1>Login</h1>
          <div>
            <label htmlFor="email-input">Email:</label>
            <input
              type="text"
              id="enail-input"
              name="email"
              value={loginForm.email}
              onChange={change}
            />
          </div>
          <div>
            <label htmlFor="password-input">Password:</label>
            <input
              type="password"
              id="password-input"
              name="password"
              value={loginForm.password}
              onChange={change}
            />
          </div>
          <button type="button" onClick={loginHandler}>
            Login
          </button>
        </form>
      )}
      {authContext.isLoggedIn && (
        <button className="logout" onClick={logoutHandler}>
          Logout
        </button>
      )}
    </>
  );
};
