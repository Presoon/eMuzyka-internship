import "../../assets/css/App.css";
import React from "react";

const Navbar = () => {
  return (
    <nav className="navbar navbar-expand-sm bg-light navbar-light sticky-top">
      <a className="navbar-brand" href="/">
        <h1 className="title-navbar">e-Muzyka</h1>
      </a>
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
            <a className="nav-link navlink" href="/">
              Strona Główna
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link navlink" href="/albumy">
              Twoje Albumy
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link navlink " href="/rejestracja">
              Rejestracja albumu
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link navlink " href="/kontakt">
              Kontakt
            </a>
          </li>
          <li className="nav-item">
            <a className="button-custom button-gradient" href="/login">
              <i className="fa fa-users mr-2" aria-hidden="true"></i>
              Login
            </a>
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
