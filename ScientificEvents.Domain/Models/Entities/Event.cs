using System;
using System.Collections.Generic;
using ScientificEvents.Domain.Models.Relationships;

namespace ScientificEvents.Domain.Models.Entities
{

    public class Event
    {
        // Primary key
        public string Code { get; set; }

        // Attributes
        public string Name { get; set; }
        public EventType Type { get; set; }
        public int AdmissionFee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Navigation properties
        public ICollection<WorkPresentation> WorkPresentations { get; set; }
    }
}