using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Relationships;

namespace ScientificEvents.EF.Configurations.Relationships
{
    public class ProductAuthorshipConfig : IEntityTypeConfiguration<ProductAuthorship>
    {
        public void Configure(EntityTypeBuilder<ProductAuthorship> builder)
        {
            builder.Property<int>("PersonId").ValueGeneratedOnAdd();
            builder.Property<int>("ProductId").ValueGeneratedOnAdd();

            builder.HasKey("PersonId", "ProductId");

            builder.HasOne(pa => pa.Author)
            .WithMany()
            .HasForeignKey("PersonId");

            builder.HasOne(pa => pa.Product)
            .WithMany()
            .HasForeignKey("ProductId");
        }
    }
}