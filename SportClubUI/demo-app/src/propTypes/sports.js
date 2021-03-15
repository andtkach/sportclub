import PropTypes from "prop-types";

export const sportPropType = PropTypes.shape({
  id: PropTypes.string,
  name: PropTypes.string,
});

export const sportsPropType = PropTypes.arrayOf(sportPropType);
