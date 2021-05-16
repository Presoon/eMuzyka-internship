import axios from "axios";
import authHeader from "./auth-header";

const API_URL = "http://localhost:5000/";

class API {
  //Albums
  getAllAlbums() {
    return axios.get(API_URL + "Album/provider", { headers: authHeader() });
  }
}

export default new API();
