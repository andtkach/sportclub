import React, { memo, forwardRef } from "react";
import PropTypes from "prop-types";

import { useForm } from "../../hooks/useForm";

export const SportForm = memo(
  forwardRef(({ onSubmitSport, buttonText }, ref) => {
    const [sportForm, change, resetSportForm] = useForm({
      name: "",
    });

    const submitSport = () => {
      onSubmitSport({ ...sportForm });
      resetSportForm();
    };

    return (
      <form>
        <div>
          <label htmlFor="name-input">Name:</label>
          <input
            type="text"
            id="name-input"
            name="name"
            ref={ref}
            value={sportForm.name}
            onChange={change}
          />
          <button type="button" onClick={submitSport}>
            {buttonText}
          </button>
        </div>
      </form>
    );
  })
);

SportForm.defaultProps = {
  buttonText: "Submit Sport",
};

SportForm.propTypes = {
  buttonText: PropTypes.string,
  onSubmitSport: PropTypes.func.isRequired,
};
