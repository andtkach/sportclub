using Application.Responses;

namespace Application.Features.Sports.Commands.CreateSport
{
    public class CreateSportCommandResponse: BaseResponse
    {
        public CreateSportCommandResponse(): base()
        {

        }

        public CreateSportDto Sport { get; set; }
    }
}