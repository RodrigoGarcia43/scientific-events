using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Relationships;

namespace ScientificEvents.EF.Configurations.Relationships
{
    public class WorkPresentationConfig : IEntityTypeConfiguration<WorkPresentation>
    {
        public void Configure(EntityTypeBuilder<WorkPresentation> builder)
        {
            builder.Property<int>("EventCode").ValueGeneratedOnAdd();
            builder.Property<int>("WorkId").ValueGeneratedOnAdd();

            builder.HasKey("PersonId", "FairId", "ProductId");

            builder.HasOne(pa => pa.Work)
            .WithMany(w => w.Presentations)
            .HasForeignKey("WorkId");

            builder.HasOne(pa => pa.Event)
            .WithMany()
            .HasForeignKey("EventCode");
        }
    }
}