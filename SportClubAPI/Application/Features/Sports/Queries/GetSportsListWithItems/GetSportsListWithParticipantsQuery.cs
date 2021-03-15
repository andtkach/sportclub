using System.Collections.Generic;
using MediatR;

namespace Application.Features.Sports.Queries.GetSportsListWithItems
{
    public class GetSportsListWithParticipantsQuery : IRequest<List<SportParticipantListVm>>
    {
    }
}
