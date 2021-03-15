using System;

namespace Application.Features.Items.Queries.GetItemDetail
{
    public class ParticipantDetailVm
    {
        public Guid Id { get; set; }
        
        public string ParticipantEmail { get; set; }
        
        public string Firstname { get; set; }
        
        public string Surname { get; set; }
        
        public Guid SportId { get; set; }
        
        public SportDto Sport { get; set; }
    }
}
