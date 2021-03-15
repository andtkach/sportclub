import React from "react";
import PropTypes from "prop-types";

import { categoryPropType } from "../../propTypes/categories";

export const ViewSportRow = ({
  category,
  onDeleteCategory: deleteCategory,
  onEditCategory: editCategory,
}) => {
  return (
    <tr>
      <td>{category.id}</td>
      <td>{category.name}</td>
      <td>
        <button type="button" onClick={() => editCategory(category.id)}>
          Edit
        </button>
        <button type="button" onClick={() => deleteCategory(category.id)}>
          Delete
        </button>
      </td>
    </tr>
  );
};

ViewSportRow.propTypes = {
  category: categoryPropType.isRequired,
  onEditCategory: PropTypes.func.isRequired,
  onDeleteCategory: PropTypes.func.isRequired,
};
