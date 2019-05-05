using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Relationships
{
    public class ProductAuthorship
    {
        public Product Product { get; set; }

        public Person Author { get; set; }
    }
}