using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Relationships
{
    public class ProductAuthorship
    {
        // Navigation properties
        public Product Product { get; set; }
        public Person Author { get; set; }
    }
}