using AutoMapper;
using Application.Contracts.Persistence;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Categories.Queries.GetCategoriesList
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
