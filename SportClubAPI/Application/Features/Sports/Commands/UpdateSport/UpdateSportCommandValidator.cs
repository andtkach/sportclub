using FluentValidation;

namespace Application.Features.Sports.Commands.UpdateSport
{
    public class UpdateSportCommandValidator : AbstractValidator<UpdateSportCommand>
    {
        public UpdateSportCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
