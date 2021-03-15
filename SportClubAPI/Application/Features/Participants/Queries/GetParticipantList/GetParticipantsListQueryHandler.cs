using AutoMapper;
using Application.Contracts.Persistence;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Items.Queries.GetItemsList
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
