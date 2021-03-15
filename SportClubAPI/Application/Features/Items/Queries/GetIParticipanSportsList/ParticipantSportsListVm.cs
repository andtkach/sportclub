using System;

namespace Application.Features.Items.Queries.GetIParticipanSportsList
{
    public class ParticipantSportsListVm
    {
        public Guid Id { get; set; }
        public string ParticipantEmail { get; set; }
        public Guid SportId { get; set; }
        public string SportName { get; set; }
    }
}
