const baseURL = "https://localhost:44330/api";

const getUrl = () => `${baseURL}/account`;

export const authenticate = async (loginInfo) => {
    const res = await fetch(`${getUrl()}/authenticate`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(loginInfo),
    });
    return await res.json();
};

export const register = async (registerInfo) => {
  const res = await fetch(`${getUrl()}/register`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(registerInfo),
  });
  return await res.json();
};
