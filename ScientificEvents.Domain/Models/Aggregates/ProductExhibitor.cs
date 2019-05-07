using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Aggregates
{
    public class ProductExhibitor
    {
        // Attributes
        public string AccommodationAddress { get; set; }
        public string PhoneNumber { get; set; }

        // Navigation properties
        public Person Person { get; set; }
        public Fair Fair { get; set; }
    }
}