using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Sports.Queries.GetSportsList
{
    public class GetSportsListQueryHandler : IRequestHandler<GetSportsListQuery, List<SportListVm>>
    {
        private readonly IAsyncRepository<Sport> _sportRepository;
        private readonly IMapper _mapper;

        public GetSportsListQueryHandler(IMapper mapper, IAsyncRepository<Sport> sportRepository)
        {
            _mapper = mapper;
            _sportRepository = sportRepository;
        }

        public async Task<List<SportListVm>> Handle(GetSportsListQuery request, CancellationToken cancellationToken)
        {
            var all = (await _sportRepository.ListAllAsync()).OrderBy(x => x.Name);
            return _mapper.Map<List<SportListVm>>(all);
        }
    }
}
