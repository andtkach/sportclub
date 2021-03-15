using AutoMapper;
using Application.Contracts.Persistence;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateSportCommandHandler : IRequestHandler<UpdateSportCommand>
    {
        private readonly IAsyncRepository<Sport> _sportRepository;
        private readonly IMapper _mapper;

        public UpdateSportCommandHandler(IMapper mapper, IAsyncRepository<Sport> sportRepository)
        {
            _mapper = mapper;
            _sportRepository = sportRepository;
        }

        public async Task<Unit> Handle(UpdateSportCommand request, CancellationToken cancellationToken)
        {

            var itemToUpdate = await _sportRepository.GetByIdAsync(request.Id);

            if (itemToUpdate == null)
            {
                throw new NotFoundException(nameof(Sport), request.Id);
            }

            var validator = new UpdateSportCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, itemToUpdate, typeof(UpdateSportCommand), typeof(Sport));

            await _sportRepository.UpdateAsync(itemToUpdate);

            return Unit.Value;
        }
    }
}