using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.EF.Configurations.Entities
{
    public class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.Code);

            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.AdmissionFee).IsRequired();
            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate).IsRequired();

            builder.Property<string>("TypeName");
            builder.HasOne(e => e.Type)
            .WithMany()
            .HasForeignKey("TypeName");
        }
    }
}