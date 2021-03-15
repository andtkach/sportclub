using System.Threading;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Sports.Queries.GetSportDetail
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
