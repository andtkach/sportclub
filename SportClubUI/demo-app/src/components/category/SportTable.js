import React, { memo } from "react";
import PropTypes from "prop-types";

import { sportsPropType } from "../../propTypes/sports";

import { EditSportRow } from "./EditSportRow";
import { ViewSportRow } from "./ViewSportRow";

export const SportTable = memo(
  ({
    sports,
    editSportId,
    onEditSport: editSport,
    onDeleteSport: deleteSport,
    onSaveSport: saveSport,
    onCancelSport: cancelSport,
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
          {sports.length === 0 && (
            <tr>
              <td colSpan="2">There are no sports.</td>
            </tr>
          )}
          {sports.map((sport) =>
            sport.id === editSportId ? (
              <EditSportRow
                key={sport.id}
                sport={sport}
                onSaveSport={saveSport}
                onCancelSport={cancelSport}
              />
            ) : (
              <ViewSportRow
                key={sport.id}
                sport={sport}
                onEditSport={editSport}
                onDeleteSport={deleteSport}
              />
            )
          )}
        </tbody>
      </table>
    );
  }
);

SportTable.defaultProps = {
  sports: [],
  editSportId: "none",
};

SportTable.propTypes = {
  sports: sportsPropType,
  editSportId: PropTypes.string,
  onEditSport: PropTypes.func.isRequired,
  onDeleteSport: PropTypes.func.isRequired,
  onSaveSport: PropTypes.func.isRequired,
  onCancelSport: PropTypes.func.isRequired,
};
