using Application.Contracts.Persistence;
using Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ParticipantRepository : BaseRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
