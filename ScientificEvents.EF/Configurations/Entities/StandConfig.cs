using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.EF.Configurations.Entities
{
    public class StandConfig : IEntityTypeConfiguration<Stand>
    {
        public void Configure(EntityTypeBuilder<Stand> builder)
        {
            builder.HasKey(s => s.Code);

            builder.Property(s => s.Location).IsRequired();
            builder.Property(s => s.Area).IsRequired();

            builder.Property<int>("FairId");
            builder.HasOne(s => s.Fair)
            .WithMany(f => f.Stands)
            .HasForeignKey("FairId");
        }
    }
}