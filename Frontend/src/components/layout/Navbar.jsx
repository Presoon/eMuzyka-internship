import "../../assets/css/App.css";
import React from "react";
import AuthService from "../../services/auth.service.js"
import {NavLink, Link} from "react-router-dom";

const Navbar = () => {
  const user = AuthService.getCurrentUser();
  return (
    <nav className="navbar navbar-expand-sm bg-light navbar-light sticky-top">
      <Link className="navbar-brand" to="/">
        <h1 className="title-navbar">e-Muzyka</h1>
      </Link>
      <button
        className="navbar-toggler"
        type="button"
        data-toggle="collapse"
        data-target="#collapsibleNavbar"
      >
        <span className="navbar-toggler-icon"></span>
      </button>
      <div
        className="collapse navbar-collapse justify-content-end"
        id="collapsibleNavbar"
      >
        <ul className="navbar-nav">
          <li className="nav-item">
            <NavLink
              className="nav-link navlink"
              exact
              to="/"
              activeClassName="selectedd"
            >
              Strona Główna
            </NavLink>
          </li>
          <li className="nav-item">
            <NavLink
              className="nav-link navlink"
              to="/albumy"
              activeClassName="selectedd"
            >
              Twoje Albumy
            </NavLink>
          </li>
          <li className="nav-item">
            <NavLink
              className="nav-link navlink "
              to="/rejestracja"
              activeClassName="selectedd"
            >
              Rejestracja albumu
            </NavLink>
          </li>
          <li className="nav-item">
            <NavLink
              className="nav-link navlink "
              to="/kontakt"
              activeClassName="selectedd"
            >
              Kontakt
            </NavLink>
          </li>
          {user === null ? (
            <li className="nav-item">
              <Link className="button-custom button-gradient" to="/login">
                <i className="fa fa-users mr-2" aria-hidden="true"></i>
                Zaloguj
              </Link>
            </li>
          ) : (
            <li className="nav-item">
              <Link className="button-custom button-gradient" to="/logout">
                <i className="fa fa-users mr-2" aria-hidden="true"></i>
                Wyloguj
              </Link>
            </li>
          )}
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
