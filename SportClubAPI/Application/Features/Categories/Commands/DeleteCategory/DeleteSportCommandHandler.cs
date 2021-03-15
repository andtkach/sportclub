using AutoMapper;
using Application.Contracts.Persistence;
using Application.Exceptions;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.DeleteCategory
{
    public class DeleteSportCommandHandler : IRequestHandler<DeleteSportCommand>
    {
        private readonly IAsyncRepository<Sport> _sportRepository;
        private readonly IMapper _mapper;
        
        public DeleteSportCommandHandler(IMapper mapper, IAsyncRepository<Sport> sportRepository)
        {
            _mapper = mapper;
            _sportRepository = sportRepository;
        }

        public async Task<Unit> Handle(DeleteSportCommand request, CancellationToken cancellationToken)
        {
            var itemToDelete = await _sportRepository.GetByIdAsync(request.Id);

            if (itemToDelete == null)
            {
                throw new NotFoundException(nameof(Sport), request.Id);
            }

            await _sportRepository.DeleteAsync(itemToDelete);

            return Unit.Value;
        }
    }
}
