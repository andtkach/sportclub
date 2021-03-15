using AutoMapper;
using Application.Contracts.Persistence;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Categories.Queries.GetCategoryDetail
{
    public class GetSportDetailQueryHandler : IRequestHandler<GetSportDetailQuery, SportDetailVm>
    {
        private readonly IAsyncRepository<Sport> _sportRepository;
        private readonly IMapper _mapper;

        public GetSportDetailQueryHandler(IMapper mapper, IAsyncRepository<Sport> sportRepository)
        {
            _mapper = mapper;
            _sportRepository = sportRepository;
        }

        public async Task<SportDetailVm> Handle(GetSportDetailQuery request, CancellationToken cancellationToken)
        {
            var sport = await _sportRepository.GetByIdAsync(request.Id);
            var sportDetailDto = _mapper.Map<SportDetailVm>(sport);
            
            return sportDetailDto;
        }
    }
}
