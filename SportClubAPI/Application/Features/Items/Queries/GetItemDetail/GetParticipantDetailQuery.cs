using MediatR;
using System;

namespace Application.Features.Items.Queries.GetItemDetail
{
    public class GetParticipantDetailQuery: IRequest<ParticipantDetailVm>
    {
        public Guid Id { get; set; }
    }
}
