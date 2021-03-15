using FluentValidation;
using Application.Contracts.Persistence;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Items.Commands.CreateItem
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
