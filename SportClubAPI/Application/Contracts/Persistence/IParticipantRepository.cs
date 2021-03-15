using Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Application.Contracts.Persistence
{
    public interface IParticipantRepository : IAsyncRepository<Participant>
    {
    }
}
