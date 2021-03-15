using AutoMapper;
using Application.Contracts.Persistence;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Items.Commands.DeleteItem
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
