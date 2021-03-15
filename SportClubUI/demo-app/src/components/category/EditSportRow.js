import React from "react";
import PropTypes from "prop-types";

import { categoryPropType } from "../../propTypes/categories";
import { useForm } from "../../hooks/useForm";
import { useDefaultInputFocus } from "../../hooks/useDefaultInputFocus";

export const EditSportRow = ({
  category,
  onSaveCategory,
  onCancelCategory: cancelCategory,
}) => {
  const [sportForm, change] = useForm({ ...category });

  const defaultInputRef = useDefaultInputFocus();

  const saveCategory = () => {
    onSaveCategory({
      ...sportForm,
      id: category.id,
    });
  };

  return (
    <tr>
      <td>{category.id}</td>
      <td>
        <input
          type="text"
          id="edit-name-input"
          name="name"
          ref={defaultInputRef}
          value={sportForm.name}
          onChange={change}
        />
      </td>
      <td>
        <button type="button" onClick={saveCategory}>
          Save
        </button>
        <button type="button" onClick={cancelCategory}>
          Cancel
        </button>
      </td>
    </tr>
  );
};

EditSportRow.propTypes = {
  category: categoryPropType.isRequired,
  onSaveCategory: PropTypes.func.isRequired,
  onCancelCategory: PropTypes.func.isRequired,
};
