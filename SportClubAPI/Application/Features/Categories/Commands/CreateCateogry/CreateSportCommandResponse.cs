using Application.Responses;

namespace Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateSportCommandResponse: BaseResponse
    {
        public CreateSportCommandResponse(): base()
        {

        }

        public CreateSportDto Sport { get; set; }
    }
}