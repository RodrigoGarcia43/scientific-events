using System.Collections.Generic;

namespace ScientificEvents.Domain.Models.Entities
{
    public class Fair
    {
        public Event Event { get; set; }

        public ICollection<Stand> Stands { get; set; }
    }
}