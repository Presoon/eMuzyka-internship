import axios from "axios";

const API_URL = "http://localhost:5000/account/";

class AuthService {
  login(username, password) {
    return axios
      .post(API_URL + "login", {
        username,
        password,
      })
      .then((response) => {
        if (response.data.token) {
          sessionStorage.setItem("user", JSON.stringify(response.data));
        }

        return response.data;
      });
  }

  logout() {
    sessionStorage.removeItem("user");
  }

  register(username, email, password) {
    return axios.post(API_URL + "signup", {
      username,
      email,
      password,
    });
  }

  getCurrentUser() {
    return JSON.parse(sessionStorage.getItem("user"));
  }
}

export default new AuthService();
