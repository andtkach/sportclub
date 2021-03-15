namespace Domain.Entities
{
    using System;

    using Domain.Common;

    public class Participant : AuditableEntity
    {
        public Guid Id { get; set; }
    
        public string ParticipantEmail { get; set; }
        
        public string Comment { get; set; }
       
        public Guid SportId { get; set; }
        
        public Sport Sport { get; set; }
    }
}
