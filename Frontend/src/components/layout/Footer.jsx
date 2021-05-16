import "../../assets/css/App.css";
import logo from "../../assets/logo-footer.png";
import React from "react";
import { Link } from "react-router-dom";

const Footer = () => {
  return (
    <div className="mt-5 px-5 py-4 text-center  mb-0 rounded-top footer">
      <div className="container">
        <div className="row">
          <div className="col-md-4 col-sm-12 p-2 my-auto">
            <a href="/">
              <img src={logo} alt="logo strony" className="w-25" />
            </a>
          </div>
          <div className="col-md-4 col-sm-12 p-2 my-auto text-light">
            <p>
              <strong>Przydatne linki:</strong>
              <br />
              <Link to="/">Regulaminy usługi</Link>
              <br />
              <Link to="/">Polityka Prywatności</Link>
            </p>
          </div>
          <div className="col-md-4 col-sm-12  my-auto text-light">
            <h3 className="">e-Muzyka.pl 2021</h3>
            <span>
              Made with <i className="fa fa-heart text-danger"></i> by{" "}
              <a
                target="_blank"
                rel="noreferrer"
                href="https://github.com/Presoon"
              >
                Szpak Kamil
              </a>
              .
            </span>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Footer;
