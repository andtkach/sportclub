using AutoMapper;
using Application.Contracts.Persistence;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Items.Queries.GetItemDetail
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
