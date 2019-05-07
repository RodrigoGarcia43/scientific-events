using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Relationships;

namespace ScientificEvents.EF.Configurations.Relationships
{
    public class ProductExhibitionConfig : IEntityTypeConfiguration<ProductExhibition>
    {
        public void Configure(EntityTypeBuilder<ProductExhibition> builder)
        {
            builder.Property<int>("PersonId").ValueGeneratedOnAdd();
            builder.Property<int>("FairId").ValueGeneratedOnAdd();
            builder.Property<int>("ProductId").ValueGeneratedOnAdd();

            builder.HasKey("PersonId", "FairId", "ProductId");

            builder.HasOne(pa => pa.Exhibitor)
            .WithMany()
            .HasForeignKey("PersonId", "FairId");

            builder.HasOne(pa => pa.Product)
            .WithMany()
            .HasForeignKey("ProductId");
        }
    }
}