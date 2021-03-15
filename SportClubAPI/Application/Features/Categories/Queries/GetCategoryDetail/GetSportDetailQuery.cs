using MediatR;
using System;

namespace Application.Features.Categories.Queries.GetCategoryDetail
{
    public class GetSportDetailQuery: IRequest<SportDetailVm>
    {
        public Guid Id { get; set; }
    }
}
