using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Relationships
{
    public class WorkPresentation
    {
        // Navigation properties
        public Work Work { get; set; }
        public Event Event { get; set; }
    }
}