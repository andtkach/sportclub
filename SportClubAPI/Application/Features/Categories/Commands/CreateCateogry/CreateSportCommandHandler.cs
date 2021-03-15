using AutoMapper;
using Application.Contracts.Persistence;
using Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.CreateCateogry
{
    public class CreateSportCommandHandler : IRequestHandler<CreateSportCommand, CreateSportCommandResponse>
    {
        private readonly IAsyncRepository<Sport> _sportRepository;
        private readonly IMapper _mapper;

        public CreateSportCommandHandler(IMapper mapper, IAsyncRepository<Sport> sportRepository)
        {
            _mapper = mapper;
            _sportRepository = sportRepository;
        }

        public async Task<CreateSportCommandResponse> Handle(CreateSportCommand request, CancellationToken cancellationToken)
        {
            var createSportCommandResponse = new CreateSportCommandResponse();

            var validator = new CreateSportCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createSportCommandResponse.Success = false;
                createSportCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createSportCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createSportCommandResponse.Success)
            {
                var sport = new Sport() { Name = request.Name };
                sport = await _sportRepository.AddAsync(sport);
                createSportCommandResponse.Sport = _mapper.Map<CreateSportDto>(sport);
            }

            return createSportCommandResponse;
        }
    }
}
