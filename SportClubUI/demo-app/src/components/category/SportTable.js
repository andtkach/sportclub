import React, { memo } from "react";
import PropTypes from "prop-types";

import { categoriesPropType } from "../../propTypes/categories";

import { EditSportRow } from "./EditSportRow";
import { ViewSportRow } from "./ViewSportRow";

export const SportTable = memo(
  ({
    categories,
    editCategoryId,
    onEditCategory: editCategory,
    onDeleteCategory: deleteCategory,
    onSaveCategory: saveCategory,
    onCancelCategory: cancelCategory,
  }) => {
    return (
      <table>
        <thead>
          <tr>
            <th>Id</th>
            <th>
              <label htmlFor="edit-name-input">Name</label>
            </th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {categories.length === 0 && (
            <tr>
              <td colSpan="2">There are no categories.</td>
            </tr>
          )}
          {categories.map((category) =>
            category.id === editCategoryId ? (
              <EditSportRow
                key={category.id}
                category={category}
                onSaveCategory={saveCategory}
                onCancelCategory={cancelCategory}
              />
            ) : (
              <ViewSportRow
                key={category.id}
                category={category}
                onEditCategory={editCategory}
                onDeleteCategory={deleteCategory}
              />
            )
          )}
        </tbody>
      </table>
    );
  }
);

SportTable.defaultProps = {
  categories: [],
  editCategoryId: "none",
};

SportTable.propTypes = {
  categories: categoriesPropType,
  editCategoryId: PropTypes.string,
  onEditCategory: PropTypes.func.isRequired,
  onDeleteCategory: PropTypes.func.isRequired,
  onSaveCategory: PropTypes.func.isRequired,
  onCancelCategory: PropTypes.func.isRequired,
};
