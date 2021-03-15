using System;
using System.Collections.Generic;

namespace Application.Features.Categories.Queries.GetCategoriesListWithItems
{
    public class SportParticipantListVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<SportParticipantDto> Participants { get; set; }
    }
}
