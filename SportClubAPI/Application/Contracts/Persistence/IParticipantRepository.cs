using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contracts.Persistence
{
    public interface IParticipantRepository : IAsyncRepository<Participant>
    {
        Task<List<Participant>> GetSportsForParticipant(string email);
    }
}
