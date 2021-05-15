import "./assets/css/App.css";

import React from "react";
import Navbar from "./components/layout/Navbar";
import Header from "./components/layout/Header";
import Footer from "./components/layout/Footer";

import NoPage from "./pages/404";
import { BrowserRouter, Switch, Route } from "react-router-dom";
import Login from "./pages/Login.js";

const App = () => {
  return (
    <div className="body-app">
      <BrowserRouter>
        <Navbar />
        <Header />
        <Switch>
          
          <Route path="/login" exact component={Login} />
          <Route component={NoPage} />
        </Switch>
        <Footer />
      </BrowserRouter>
    </div>
  );
};

export default App;
