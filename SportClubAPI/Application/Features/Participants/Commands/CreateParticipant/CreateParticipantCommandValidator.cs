using Application.Contracts.Persistence;
using FluentValidation;

namespace Application.Features.Participants.Commands.CreateParticipant
{
    public class CreateParticipantCommandValidator : AbstractValidator<CreateParticipantCommand>
    {
        private readonly IParticipantRepository _participantRepository;

        public CreateParticipantCommandValidator(IParticipantRepository participantRepository)
        {
            _participantRepository = participantRepository;

            RuleFor(p => p.ParticipantEmail)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");
        }
    }
}
