using MediatR;
using System.Collections.Generic;
using Application.Features.Participants.Queries.GetParticipantList;

namespace Application.Features.Items.Queries.GetItemsList
{
    public class GetParticipantsListQuery: IRequest<List<ParticipantListVm>>
    {

    }
}
