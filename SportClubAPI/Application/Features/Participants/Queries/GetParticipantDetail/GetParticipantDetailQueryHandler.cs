using System.Threading;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using Application.Exceptions;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Participants.Queries.GetParticipantDetail
{
    public class GetParticipantDetailQueryHandler : IRequestHandler<GetParticipantDetailQuery, ParticipantDetailVm>
    {
        private readonly IAsyncRepository<Participant> _participantRepository;
        private readonly IAsyncRepository<Sport> _sportRepository;
        private readonly IMapper _mapper;

        public GetParticipantDetailQueryHandler(IMapper mapper, IAsyncRepository<Participant> participantRepository, 
            IAsyncRepository<Sport> sportRepository)
        {
            _mapper = mapper;
            _participantRepository = participantRepository;
            _sportRepository = sportRepository;
        }

        public async Task<ParticipantDetailVm> Handle(GetParticipantDetailQuery request, CancellationToken cancellationToken)
        {
            var participant = await _participantRepository.GetByIdAsync(request.Id);
            var participantDetailDto = _mapper.Map<ParticipantDetailVm>(participant);
            
            var sport = await _sportRepository.GetByIdAsync(participant.SportId);

            if (sport == null)
            {
                throw new NotFoundException(nameof(Sport), request.Id);
            }
            participantDetailDto.Sport = _mapper.Map<SportDto>(sport);

            return participantDetailDto;
        }
    }
}
