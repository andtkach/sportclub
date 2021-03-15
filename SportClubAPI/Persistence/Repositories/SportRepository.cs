using Application.Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class SportRepository : BaseRepository<Sport>, ISportRepository
    {
        public SportRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Sport>> GetSportsWithParticipants()
        {
            var all = await _dbContext.Sports.Include(x => x.Participants).ToListAsync();
            return all;
        }
    }
}
