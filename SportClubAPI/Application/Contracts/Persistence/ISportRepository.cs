using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contracts.Persistence
{
    public interface ISportRepository : IAsyncRepository<Sport>
    {
        Task<List<Sport>> GetSportsWithParticipants();
    }
}
