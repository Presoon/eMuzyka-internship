export default function authHeader() {
  const token = sessionStorage.getItem("token");

  if (token) {
    return {
      Authorization: "Bearer " + token,
      "Access-Control-Allow-Origin": "*",
    };
  } else {
    return {};
  }
}
