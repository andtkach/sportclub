using System;

namespace Application.Features.Sports.Commands.CreateSport
{
    public class CreateSportDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
