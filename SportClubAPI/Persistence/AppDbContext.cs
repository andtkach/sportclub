using Application.Contracts;
using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence
{
    public class AppDbContext: DbContext
    {
        private readonly ILoggedInUserService _loggedInUserService;

        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options, ILoggedInUserService loggedInUserService)
            : base(options)
        {
            _loggedInUserService = loggedInUserService;
        }

        public DbSet<Participant> Participants { get; set; }

        public DbSet<Sport> Sports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            var tennisGuid = Guid.NewGuid();
            modelBuilder.Entity<Sport>().HasData(new Sport
            {
                Id = tennisGuid,
                Name = "Tennis"
            });

            modelBuilder.Entity<Sport>().HasData(new Sport
            {
                Id = Guid.NewGuid(),
                Name = "Squash"
            });

            modelBuilder.Entity<Participant>().HasData(new Participant
            {
                Id = Guid.NewGuid(),
                ParticipantEmail = "johndoe@email.com",
                SportId = tennisGuid
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = _loggedInUserService.UserId;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = _loggedInUserService.UserId;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
