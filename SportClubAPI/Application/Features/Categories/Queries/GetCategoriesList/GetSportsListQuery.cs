using MediatR;
using System.Collections.Generic;

namespace Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetSportsListQuery : IRequest<List<SportListVm>>
    {
    }
}
