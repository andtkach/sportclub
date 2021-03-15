using MediatR;
using System;

namespace Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateSportCommand: IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
