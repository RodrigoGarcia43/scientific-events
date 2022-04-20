using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.EF.Configurations.Entities
{
    public class EventTypeConfig : IEntityTypeConfiguration<EventType>
    {
        public void Configure(EntityTypeBuilder<EventType> builder)
        {
            builder.HasKey(et => et.Name);
        }
    }
}