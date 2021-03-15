using System;
using System.Collections.Generic;

namespace Application.Features.Sports.Queries.GetSportsListWithItems
{
    public class SportParticipantListVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<SportParticipantDto> Participants { get; set; }
    }
}
