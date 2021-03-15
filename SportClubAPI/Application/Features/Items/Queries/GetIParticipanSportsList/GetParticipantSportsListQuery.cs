using MediatR;
using System.Collections.Generic;

namespace Application.Features.Items.Queries.GetIParticipanSportsList
{
    public class GetParticipantSportsListQuery : IRequest<List<ParticipantSportsListVm>>
    {
        public string Email { get; set; }
    }
}
