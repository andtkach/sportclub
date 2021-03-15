import PropTypes from "prop-types";

export const categoryPropType = PropTypes.shape({
  id: PropTypes.string,
  name: PropTypes.string,
});

export const categoriesPropType = PropTypes.arrayOf(categoryPropType);
