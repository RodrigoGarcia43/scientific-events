using ScientificEvents.Domain.Models.Aggregates;
using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Relationships
{
    public class ProductExhibition
    {
        // Navigation properties
        public Product Product { get; set; }
        public ProductExhibitor Exhibitor { get; set; }
    }
}