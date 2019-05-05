using System.Collections.Generic;

namespace ScientificEvents.Domain.Models.Entities
{
    public class Stand
    {
        public string Code { get; set; }

        public string Location { get; set; }

        public int Area { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}