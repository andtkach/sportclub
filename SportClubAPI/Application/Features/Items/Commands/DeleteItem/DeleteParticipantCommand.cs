using MediatR;
using System;

namespace Application.Features.Items.Commands.DeleteItem
{
    public class DeleteParticipantCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
