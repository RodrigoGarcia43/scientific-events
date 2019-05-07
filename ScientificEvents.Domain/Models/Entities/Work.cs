using System.Collections.Generic;
using ScientificEvents.Domain.Models.Relationships;

namespace ScientificEvents.Domain.Models.Entities
{
    public class Work
    {
        // Attribute
        public string Title { get; set; }

        // Navigation properties
        public ICollection<WorkPresentation> Presentations { get; set; }
    }
}