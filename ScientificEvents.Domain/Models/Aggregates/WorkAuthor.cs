using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.Domain.Models.Aggregates
{
    public class WorkAuthor
    {
        public Person Person { get; set; }

        public Work Work { get; set; }
    }
}