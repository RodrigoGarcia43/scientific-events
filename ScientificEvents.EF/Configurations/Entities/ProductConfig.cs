using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.EF.Configurations.Entities
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Code);

            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description).IsRequired();

            builder.Property<string>("StandCode");
            builder.HasOne(p => p.Stand)
            .WithMany(s => s.Products)
            .HasForeignKey("StandCode");
        }
    }
}