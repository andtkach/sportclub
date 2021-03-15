using Application.Contracts.Persistence;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ParticipantRepository : BaseRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Participant>> GetSportsForParticipant(string email)
        {
            var all = await _dbContext.Participants
                .Include(p => p.Sport)
                .Where(p => p.ParticipantEmail.ToUpper() == email.ToUpper())
                .ToListAsync();
            return all;
        }
    }
}
