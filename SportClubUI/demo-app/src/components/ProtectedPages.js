import React, { useContext } from "react";
import { AuthContext } from "../context";

import { SportsApp } from "../components/category/SportsApp";

export const ProtectedPages = () => {
  const authContext = useContext(AuthContext);

  return (
    authContext.isLoggedIn && (
      <>
        <SportsApp />
      </>
    )
  );
};
