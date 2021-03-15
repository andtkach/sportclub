using System;
using MediatR;

namespace Application.Features.Sports.Commands.UpdateSport
{
    public class UpdateSportCommand: IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
