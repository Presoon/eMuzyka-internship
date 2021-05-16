import "../assets/css/App.css";
import React from "react";

const HomePage = () => {
  return (
    <div className="container">
      <div className="row">
        <h1 className="titlex position-relative mt-5 mt-5 mb-5 ">
          Witaj w panelu dostawcy!
        </h1>
      </div>
      <div className="row justify-content-center">
        <div className="col-sm-12 col-xl-10">
          <div className="card shadow-lg o-hidden border-0 my-5">
            <div className="card-body p-0">
              <div className="row">
                <div className="col-lg-6 col-sm-12 d-flex">
                  <div className="p-5">
                    <div className="text-center">
                      <h4 className="text-dark mb-4">Aplikacja e-Muzyka</h4>
                      <div className="text-left">
                        <p>
                          Aplikacja stworzona na potrzeby procesu rekrutacji na
                          stanowisko stażysty w firmie EUVIC. <br />
                          Frontend aplikacji napisany został we frameworku
                          React.JS, natomiast Backend implementuje REST API w
                          technologii ASP.NET Core.
                        </p>
                      </div>
                      <br />
                    </div>
                  </div>
                </div>
                <div className="col-lg-6 col-sm-12  d-flex">
                  <div className="p-5">
                    <div className="text-center">
                      <h4 className="text-dark mb-4">
                        Działania dostępne po zalogowaniu do panelu:
                      </h4>
                      <div className="text-left">
                        <ul>
                          <li>Przegląd zarejestrowanych albumów</li>
                          <li>Szczegółowe informacje o albumie</li>
                          <li>Lista tracków dostepnych w albumie</li>
                          <li>Szczegółowe informacje o tracku</li>
                          <li>Rejestracja albumów (wkrótce)</li>
                        </ul>
                      </div>
                      <br />
                    </div>
                  </div>
                </div>
              </div>
              <div className="row"></div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default HomePage;
