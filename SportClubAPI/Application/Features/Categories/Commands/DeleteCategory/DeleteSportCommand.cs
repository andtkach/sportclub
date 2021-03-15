using MediatR;
using System;

namespace Application.Features.Categories.Commands.DeleteCategory
{
    public class DeleteSportCommand: IRequest
    {
        public Guid Id { get; set; }
    }
}
