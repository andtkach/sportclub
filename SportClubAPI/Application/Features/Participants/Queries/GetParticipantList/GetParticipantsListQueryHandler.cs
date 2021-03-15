using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Participants.Queries.GetParticipantList
{
    public class GetParticipantsListQueryHandler : IRequestHandler<GetParticipantsListQuery, List<ParticipantListVm>>
    {
        private readonly IAsyncRepository<Participant> _participantRepository;
        private readonly IMapper _mapper;

        public GetParticipantsListQueryHandler(IMapper mapper, IAsyncRepository<Participant> participantRepository)
        {
            _mapper = mapper;
            _participantRepository = participantRepository;
        }

        public async Task<List<ParticipantListVm>> Handle(GetParticipantsListQuery request, CancellationToken cancellationToken)
        {
            var allItems = (await _participantRepository.ListAllAsync());
            return _mapper.Map<List<ParticipantListVm>>(allItems);
        }
    }
}
