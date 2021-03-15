using MediatR;
using System;

namespace Application.Features.Items.Commands.CreateItem
{
    public class CreateParticipantCommand: IRequest<Guid>
    {
        public string ParticipantEmail { get; set; }
        public Guid SportId { get; set; }
        public override string ToString()
        {
            return $"Item name: {ParticipantEmail};";
        }
    }
}
