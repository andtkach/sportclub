namespace Domain.Entities
{
    using System;
    using System.Collections.Generic;

    using Domain.Common;

    public class Sport : AuditableEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Participant> Participants { get; set; }
    }
}
