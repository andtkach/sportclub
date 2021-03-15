import React, { useState, useCallback, useEffect } from "react";

import { useDefaultInputFocus } from "../../hooks/useDefaultInputFocus";
import {
  getAllSports as apiGetAllSports,
  createSport as apiCreateSport,
  updateSport as apiUpdateSport,
  deleteSport as apiDeleteSport,
} from "../../services/sports";

import { SportHeader } from "./SportHeader";
import { SportTable } from "./SportTable";
import { SportForm } from "./SportForm";

export const SportsApp = () => {
  const [sports, setSports] = useState([]);
  const [editSportId, setEditSportId] = useState("none");

  const defaultInputRef = useDefaultInputFocus();

  const init = useCallback(() => {
    setEditSportId("none");
    if (defaultInputRef.current) {
      defaultInputRef.current.focus();
    }
  }, [defaultInputRef]);

  const refreshSports = useCallback(() => {
    apiGetAllSports().then((sports) => {
      setSports(sports);
      init();
    });
  }, [init]);

  useEffect(() => {
    refreshSports();
  }, [refreshSports]);

  const addSport = useCallback(
    (sport) => {
      apiCreateSport(sport).then(refreshSports);
    },
    [refreshSports]
  );

  const replaceSport = useCallback(
    (sport) => {
      apiUpdateSport(sport).then(refreshSports);
    },
    [refreshSports]
  );

  const deleteSport = useCallback(
    (id) => {
      apiDeleteSport(id).then(refreshSports);
    },
    [refreshSports]
  );

  const cancelSport = useCallback(() => {
    init();
  }, [init]);

  return (
    <>
      <SportHeader headerText="Catalog" />
      <SportForm
        buttonText="Add Sport"
        onSubmitSport={addSport}
        ref={defaultInputRef}
      />
      <SportTable
        sports={sports}
        editSportId={editSportId}
        onEditSport={setEditSportId}
        onDeleteSport={deleteSport}
        onSaveSport={replaceSport}
        onCancelSport={cancelSport}
      />
    </>
  );
};
