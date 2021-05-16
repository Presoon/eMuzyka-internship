import axios from "axios";
import authHeader from "./auth-header";

const API_URL = "http://localhost:5000/";

class API {
  //Albums
  getAllAlbums() {
    return axios.get(API_URL + "album/provider", { headers: authHeader() });
  }

  getAlbumInfoWithTracks(id) {
    return axios.get(API_URL + "album/" + id + "/tracks", {
      headers: authHeader(),
    });
  }

  //Provider functions
  getProviderInfo() {
    return axios.get(API_URL + "provider/me", { headers: authHeader() });
  }
}

export default new API();
