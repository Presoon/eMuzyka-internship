import axios from "axios";

const API_URL = "https://api-emuzyka.azurewebsites.net/account/";

class AuthService {
  login(username, password) {
    return axios
      .post(API_URL + "login", {
        username,
        password,
      })
      .then((response) => {
        if (response.data) {
          sessionStorage.setItem("token", response.data);
        }

        return response.data;
      });
  }

  logout() {
    sessionStorage.removeItem("token");
  }

  register(username, email, password) {
    return axios.post(API_URL + "signup", {
      username,
      email,
      password,
    });
  }

  getCurrentUser() {
    
    return sessionStorage.getItem("token");
  }
}

export default new AuthService();
