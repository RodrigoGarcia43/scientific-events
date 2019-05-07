using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.EF.Configurations.Entities
{
    public class FairConfig : IEntityTypeConfiguration<Fair>
    {
        public void Configure(EntityTypeBuilder<Fair> builder)
        {
            builder.Property<int>("Id").ValueGeneratedOnAdd();
            builder.HasKey("Id");

            builder.Property<string>("EventCode");
            builder.HasOne(f => f.Event)
            .WithOne()
            .HasForeignKey<Fair>("EventCode");
        }
    }
}