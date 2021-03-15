using MediatR;

namespace Application.Features.Sports.Commands.CreateSport
{
    public class CreateSportCommand: IRequest<CreateSportCommandResponse>
    {
        public string Name { get; set; }
    }
}
