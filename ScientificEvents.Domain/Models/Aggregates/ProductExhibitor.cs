using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Aggregates
{
    public class ProductExhibitor
    {
        public Person Person { get; set; }

        public Fair Event { get; set; }

        public string AccommodationAddress { get; set; }

        public string PhoneNumber { get; set; }
    }
}