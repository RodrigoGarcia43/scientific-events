using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Aggregates
{
    public class EventParticipant
    {
        // Primary key
        public string Registration { get; set; }

        // Attributes
        public string Country { get; set; }
        public string Email { get; set; }

        // Navigation properties
        public Person Person { get; set; }
        public Event Event { get; set; }

    }
}