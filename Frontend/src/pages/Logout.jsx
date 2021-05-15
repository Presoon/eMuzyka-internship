import "../assets/css/App.css";
import React from "react";
import AuthService from "../services/auth.service";

const Logout = () => {
  const logout = () => {
    if (AuthService.getCurrentUser() != null) {
      AuthService.logout();
      window.location.reload();
    }
  };

  logout();

  return (
    <div className="container" style={{ height: 450 }}>
      <div className="row">
        <h1 className="titlex position-relative mt-5 mt-5 mb-5 ">
          Zostałeś pomyślnie wylogowany!
        </h1>
      </div>
    </div>
  );
};

export default Logout;
