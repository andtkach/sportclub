using System.Collections.Generic;
using MediatR;

namespace Application.Features.Sports.Queries.GetSportsList
{
    public class GetSportsListQuery : IRequest<List<SportListVm>>
    {
    }
}
