namespace ScientificEvents.Domain.Models.Entities
{
    public class Product
    {
        // Primary key
        public string Code { get; set; }

        // Atributes
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation property
        public Stand Stand { get; set; }
    }
}