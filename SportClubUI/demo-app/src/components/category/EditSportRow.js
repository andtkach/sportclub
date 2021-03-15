import React from "react";
import PropTypes from "prop-types";

import { sportPropType } from "../../propTypes/sports";
import { useForm } from "../../hooks/useForm";
import { useDefaultInputFocus } from "../../hooks/useDefaultInputFocus";

export const EditSportRow = ({
  sport,
  onSaveSport,
  onCancelSport: cancelSport,
}) => {
  const [sportForm, change] = useForm({ ...sport });

  const defaultInputRef = useDefaultInputFocus();

  const saveSport = () => {
    onSaveSport({
      ...sportForm,
      id: sport.id,
    });
  };

  return (
    <tr>
      <td>{sport.id}</td>
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
        <button type="button" onClick={saveSport}>
          Save
        </button>
        <button type="button" onClick={cancelSport}>
          Cancel
        </button>
      </td>
    </tr>
  );
};

EditSportRow.propTypes = {
  sport: sportPropType.isRequired,
  onSaveSport: PropTypes.func.isRequired,
  onCancelSport: PropTypes.func.isRequired,
};
