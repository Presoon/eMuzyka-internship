import "../../assets/css/App.css";
import React from "react";
import logo from "../../assets/logo.jpg";


const Header = () => {
  return (
    <div className="headerx text-center mb-5">
      <div className="container">
        <div className="row">
          <div className="col-md-8 col-sm-12 text-center p-3 my-auto">
            <span className="header-title mb-0">Naszą siłą jest muzyka</span>
            <br />
            <p className="">Sprawdź naszą ofertę!</p>
            <div className="row mt-4 ">
              <a
                className="button-custom button-gradient mx-auto"
                href="https://e-muzyka.pl"
                target="_blank"
                rel="noreferrer"
              >
                <span>Strona informacyjna</span>
              </a>
            </div>
          </div>
          <div className="col-md-4 col-sm-12 p-3 my-auto">
            <img src={logo} className="logo-header" alt="" />
          </div>
        </div>
      </div>
    </div>
  );
};

export default Header;
