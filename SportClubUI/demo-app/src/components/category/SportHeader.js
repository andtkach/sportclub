import React, { memo } from "react";
import PropTypes from "prop-types";

export const SportHeader = memo(({ headerText }) => {
  return (
    <header>
      <h1>{headerText}</h1>
    </header>
  );
});

SportHeader.defaultProps = {
  headerText: "App",
};

SportHeader.propTypes = {
  headerText: PropTypes.string,
};
