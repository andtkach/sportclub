using System;
using MediatR;

namespace Application.Features.Sports.Queries.GetSportDetail
{
    public class GetSportDetailQuery: IRequest<SportDetailVm>
    {
        public Guid Id { get; set; }
    }
}
