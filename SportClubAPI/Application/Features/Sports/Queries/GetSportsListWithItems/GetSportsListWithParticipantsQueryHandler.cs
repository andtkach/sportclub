using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace Application.Features.Sports.Queries.GetSportsListWithItems
{
    public class GetSportsListWithParticipantsQueryHandler : IRequestHandler<GetSportsListWithParticipantsQuery, List<SportParticipantListVm>>
    {
        private readonly IMapper _mapper;
        private readonly ISportRepository _sportRepository;

        public GetSportsListWithParticipantsQueryHandler(IMapper mapper, ISportRepository sportRepository)
        {
            _mapper = mapper;
            _sportRepository = sportRepository;
        }

        public async Task<List<SportParticipantListVm>> Handle(GetSportsListWithParticipantsQuery request, CancellationToken cancellationToken)
        {
            var list = await _sportRepository.GetSportsWithParticipants();
            return _mapper.Map<List<SportParticipantListVm>>(list);
        }
    }
}
