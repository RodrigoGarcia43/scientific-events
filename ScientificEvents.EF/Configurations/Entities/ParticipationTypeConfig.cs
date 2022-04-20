using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScientificEvents.Domain.Models.Entities;

namespace ScientificEvents.EF.Configurations.Entities
{
    public class ParticipationTypeConfig : IEntityTypeConfiguration<ParticipationType>
    {
        public void Configure(EntityTypeBuilder<ParticipationType> builder)
        {
            builder.HasKey(pt => pt.Name);
        }
    }
}