using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Contracts.Persistence;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Features.Participants.Commands.CreateParticipant
{
    public class CreateParticipantCommandHandler : IRequestHandler<CreateParticipantCommand, Guid>
    {
        private readonly IParticipantRepository _participantRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateParticipantCommandHandler> _logger;


        public CreateParticipantCommandHandler(IMapper mapper, IParticipantRepository participantRepository, ILogger<CreateParticipantCommandHandler> logger)
        {
            _mapper = mapper;
            _participantRepository = participantRepository;
            _logger = logger;
        }

        public async Task<Guid> Handle(CreateParticipantCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateParticipantCommandValidator(_participantRepository);
            var validationResult = await validator.ValidateAsync(request);
            
            if (validationResult.Errors.Count > 0)
                throw new Exceptions.ValidationException(validationResult);

            var item = _mapper.Map<Participant>(request);

            item = await _participantRepository.AddAsync(item);

            return item.Id;
        }
    }
}