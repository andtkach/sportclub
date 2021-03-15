using MediatR;
using System;

namespace Application.Features.Items.Commands.UpdateItem
{
    public class UpdateParticipantCommand: IRequest
    {
        public Guid Id { get; set; }
        public string ParticipantEmail { get; set; }
        public Guid SportId { get; set; }
    }
}
