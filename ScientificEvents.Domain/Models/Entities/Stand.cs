using System.Collections.Generic;

namespace ScientificEvents.Domain.Models.Entities
{
    public class Stand
    {
        // Primary key
        public string Code { get; set; }

        // Attributes
        public string Location { get; set; }

        public int Area { get; set; }

        // Navigation properties
        public Fair Fair { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}