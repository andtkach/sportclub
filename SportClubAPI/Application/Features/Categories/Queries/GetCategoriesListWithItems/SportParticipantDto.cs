using System;

namespace Application.Features.Categories.Queries.GetCategoriesListWithItems
{
    public class SportParticipantDto
    {
        public Guid Id { get; set; }
        public string ParticipantEmail { get; set; }
        public Guid SportId { get; set; }
    }
}
