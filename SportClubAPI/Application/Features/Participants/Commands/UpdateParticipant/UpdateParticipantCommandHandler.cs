using System.Threading;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using Application.Exceptions;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Participants.Commands.UpdateParticipant
{
    public class UpdateParticipantCommandHandler : IRequestHandler<UpdateParticipantCommand>
    {
        private readonly IAsyncRepository<Participant> _participantRepository;
        private readonly IMapper _mapper;

        public UpdateParticipantCommandHandler(IMapper mapper, IAsyncRepository<Participant> participantRepository)
        {
            _mapper = mapper;
            _participantRepository = participantRepository;
        }

        public async Task<Unit> Handle(UpdateParticipantCommand request, CancellationToken cancellationToken)
        {

            var itemToUpdate = await _participantRepository.GetByIdAsync(request.Id);

            if (itemToUpdate == null)
            {
                throw new NotFoundException(nameof(Participant), request.Id);
            }

            var validator = new UpdateParticipantCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, itemToUpdate, typeof(UpdateParticipantCommand), typeof(Participant));

            await _participantRepository.UpdateAsync(itemToUpdate);

            return Unit.Value;
        }
    }
}