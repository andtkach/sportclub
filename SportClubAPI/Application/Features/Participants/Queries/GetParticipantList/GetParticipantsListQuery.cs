using System.Collections.Generic;
using MediatR;

namespace Application.Features.Participants.Queries.GetParticipantList
{
    public class GetParticipantsListQuery: IRequest<List<ParticipantListVm>>
    {

    }
}
