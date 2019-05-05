using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Aggregates
{
    public class EventParticipant
    {
        public Person Person { get; set; }

        public Event Event { get; set; }

        public string Registration { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }
    }
}