using System;
using MediatR;

namespace Application.Features.Participants.Queries.GetParticipantDetail
{
    public class GetParticipantDetailQuery: IRequest<ParticipantDetailVm>
    {
        public Guid Id { get; set; }
    }
}
