import { BrowserRouter, Switch, Route } from "react-router-dom";
import "./assets/css/App.css";
import React from "react";

// Import Layout
import Navbar from "./components/layout/Navbar";
import Header from "./components/layout/Header";
import Footer from "./components/layout/Footer";

//Import Pages
import NoPage from "./pages/404";
import Login from "./pages/Login.js";
import Logout from "./pages/Logout";
import Albums from "./pages/Albums";
import AlbumInfo from "./pages/AlbumInfo";
import HomePage from "./pages/HomePage";
import RegisterAlbum from "./pages/RegisterAlbum";
import Profile from "./pages/Profile";

const App = () => {
  return (
    <div className="body-app">
      <BrowserRouter>
        <Navbar />
        <Header />
        <Switch>
          <Route path="/" exact component={HomePage} />
          <Route path="/login" component={Login} />
          <Route path="/logout" component={Logout} />
          <Route path="/albums" component={Albums} />
          <Route path="/albuminfo/:id" component={AlbumInfo} />
          <Route path="/register-album" component={RegisterAlbum} />
          <Route path="/profile" component={Profile} />
          <Route component={NoPage} />
        </Switch>
        <Footer />
      </BrowserRouter>
    </div>
  );
};

export default App;
