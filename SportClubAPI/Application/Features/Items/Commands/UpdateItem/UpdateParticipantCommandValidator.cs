using FluentValidation;

namespace Application.Features.Items.Commands.UpdateItem
{
    public class UpdateParticipantCommandValidator : AbstractValidator<UpdateParticipantCommand>
    {
        public UpdateParticipantCommandValidator()
        {
            RuleFor(p => p.ParticipantEmail)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

        }
    }
}
