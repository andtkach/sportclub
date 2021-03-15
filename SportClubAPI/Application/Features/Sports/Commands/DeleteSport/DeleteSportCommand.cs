using System;
using MediatR;

namespace Application.Features.Sports.Commands.DeleteSport
{
    public class DeleteSportCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
