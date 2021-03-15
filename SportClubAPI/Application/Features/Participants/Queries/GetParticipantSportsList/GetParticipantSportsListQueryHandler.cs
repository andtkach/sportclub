using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.Participants.Queries.GetParticipantSportsList
{
    public class GetParticipantSportsListQueryHandler : IRequestHandler<GetParticipantSportsListQuery, List<ParticipantSportsListVm>>
    {
        private readonly IParticipantRepository _participantRepository;
        private readonly IMapper _mapper;

        public GetParticipantSportsListQueryHandler(IMapper mapper, IParticipantRepository participantRepository)
        {
            _mapper = mapper;
            _participantRepository = participantRepository;
        }

        public async Task<List<ParticipantSportsListVm>> Handle(GetParticipantSportsListQuery request, CancellationToken cancellationToken)
        {
            var allItems = (await _participantRepository.GetSportsForParticipant(request.Email));
            return _mapper.Map<List<ParticipantSportsListVm>>(allItems);
        }
    }
}
