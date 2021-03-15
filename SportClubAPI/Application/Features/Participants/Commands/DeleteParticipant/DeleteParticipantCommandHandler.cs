using System.Threading;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using Application.Exceptions;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Participants.Commands.DeleteParticipant
{
    public class DeleteParticipantCommandHandler : IRequestHandler<DeleteParticipantCommand>
    {
        private readonly IAsyncRepository<Participant> _participantRepository;
        private readonly IMapper _mapper;
        
        public DeleteParticipantCommandHandler(IMapper mapper, IAsyncRepository<Participant> participantRepository)
        {
            _mapper = mapper;
            _participantRepository = participantRepository;
        }

        public async Task<Unit> Handle(DeleteParticipantCommand request, CancellationToken cancellationToken)
        {
            var itemToDelete = await _participantRepository.GetByIdAsync(request.Id);

            if (itemToDelete == null)
            {
                throw new NotFoundException(nameof(Participant), request.Id);
            }

            await _participantRepository.DeleteAsync(itemToDelete);

            return Unit.Value;
        }
    }
}
