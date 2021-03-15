using MediatR;
using System.Collections.Generic;

namespace Application.Features.Categories.Queries.GetCategoriesListWithItems
{
    public class GetSportsListWithParticipantsQuery : IRequest<List<SportParticipantListVm>>
    {
    }
}
