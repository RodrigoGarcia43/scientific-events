using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Relationships
{
    public class WorkPresentation
    {
        public Work Work { get; set; }

        public Event Event { get; set; }
    }
}