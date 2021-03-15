using System.Collections.Generic;
using MediatR;

namespace Application.Features.Participants.Queries.GetParticipantSportsList
{
    public class GetParticipantSportsListQuery : IRequest<List<ParticipantSportsListVm>>
    {
        public string Email { get; set; }
    }
}
