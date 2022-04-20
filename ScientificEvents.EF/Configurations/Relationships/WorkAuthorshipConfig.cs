using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Relationships;

namespace ScientificEvents.EF.Configurations.Relationships
{
    public class WorkAuthorshipConfig : IEntityTypeConfiguration<WorkAuthorship>
    {
        public void Configure(EntityTypeBuilder<WorkAuthorship> builder)
        {
            builder.Property<int>("PersonId").ValueGeneratedOnAdd();
            builder.Property<int>("WorkId").ValueGeneratedOnAdd();

            builder.HasKey("PersonId", "WorkId");

            builder.HasOne(pa => pa.Person)
            .WithMany()
            .HasForeignKey("PersonId");

            builder.HasOne(pa => pa.Work)
            .WithMany()
            .HasForeignKey("WorkId");
        }
    }
}