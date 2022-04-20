using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Relationships
{
    public class WorkAuthorship
    {
        // Navigation properties
        public Person Person { get; set; }
        public Work Work { get; set; }
    }
}