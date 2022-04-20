using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Aggregates;

namespace ScientificEvents.EF.Configurations.Aggregates
{
    public class EventParticipantConfig : IEntityTypeConfiguration<EventParticipant>
    {
        public void Configure(EntityTypeBuilder<EventParticipant> builder)
        {
            builder.HasKey(ep => ep.Registration);

            builder.Property(ep => ep.Country).IsRequired();
            builder.Property(ep => ep.Email).IsRequired();

            builder.Property<string>("PersonId");
            builder.Property<string>("EventCode");

            builder.HasOne(pe => pe.Person)
            .WithMany()
            .HasForeignKey("PersonId");

            builder.HasOne(pe => pe.Event)
            .WithMany()
            .HasForeignKey("EventCode");
        }
    }
}