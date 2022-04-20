using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.EF.Configurations.Entities
{
    public class WorkConfig : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.Property<int>("Id");
            builder.HasKey("Id");

            builder.Property(w => w.Title).IsRequired();
        }
    }
}