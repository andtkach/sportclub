using MediatR;

namespace Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateSportCommand: IRequest<CreateSportCommandResponse>
    {
        public string Name { get; set; }
    }
}
