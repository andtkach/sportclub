const baseURL = "https://localhost:44330/api";

const getCollectionURL = () => `${baseURL}/sport`;

const getElementURL = (id) => `${getCollectionURL()}/${encodeURIComponent(id)}`;

export const getAllSports = async () => {
  const res = await fetch(`${getCollectionURL()}/all`);
  return await res.json();
};

export const createSport = async (sport) => {
  const token = getToken();
  if (token) {
    const res = await fetch(getCollectionURL(), {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + token,
      },
      body: JSON.stringify(sport),
    });
    return await res.json();
  }
  console.log("Not authorized");
};

export const updateSport = async (sport) => {
  const token = getToken();
  if (token) {
    const res = await fetch(getCollectionURL(), {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + token,
      },
      body: JSON.stringify(sport),
    });
    return await res.status;
  }
  return null;
};

export const deleteSport = async (id) => {
  const token = getToken();
  if (token) {
    await fetch(getElementURL(id), {
      method: "DELETE",
      headers: { Authorization: "Bearer " + token },
    });
  }
  return null;
};

const getToken = () => {
  const storedData = JSON.parse(localStorage.getItem("userData"));
  if (
    storedData &&
    storedData.token &&
    new Date(storedData.expirationTime) > new Date()
  ) {
    return storedData.token;
  }

  return null;
};
