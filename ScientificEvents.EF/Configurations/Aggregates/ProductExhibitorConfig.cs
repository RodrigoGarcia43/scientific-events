using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Aggregates;

namespace ScientificEvents.EF.Configurations.Aggregates
{
    public class ProductExhibitorConfig : IEntityTypeConfiguration<ProductExhibitor>
    {
        public void Configure(EntityTypeBuilder<ProductExhibitor> builder)
        {
            builder.Property<string>("PersonId");
            builder.Property<int>("FairId");

            builder.HasKey("PersonId", "FairId");

            builder.Property(pe => pe.AccommodationAddress).IsRequired();
            builder.Property(pe => pe.PhoneNumber).IsRequired();

            builder.HasOne(pe => pe.Person)
            .WithMany()
            .HasForeignKey("PersonId");

            builder.HasOne(pe => pe.Fair)
            .WithMany()
            .HasForeignKey("FairId");
        }
    }
}