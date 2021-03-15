import React from "react";
import PropTypes from "prop-types";

import { sportPropType } from "../../propTypes/sports";

export const ViewSportRow = ({
  sport,
  onDeleteSport: deleteSport,
  onEditSport: editSport,
}) => {
  return (
    <tr>
      <td>{sport.id}</td>
      <td>{sport.name}</td>
      <td>
        <button type="button" onClick={() => editSport(sport.id)}>
          Edit
        </button>
        <button type="button" onClick={() => deleteSport(sport.id)}>
          Delete
        </button>
      </td>
    </tr>
  );
};

ViewSportRow.propTypes = {
  sport: sportPropType.isRequired,
  onEditSport: PropTypes.func.isRequired,
  onDeleteSport: PropTypes.func.isRequired,
};
