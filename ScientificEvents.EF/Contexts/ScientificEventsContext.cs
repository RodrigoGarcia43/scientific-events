using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using ScientificEvents.Domain.Models.Relationships;
using ScientificEvents.Domain.Models.Aggregates;
using ScientificEvents.Domain.Models.Entities;
using ScientificEvents.EF.Configurations.Aggregates;
using ScientificEvents.EF.Configurations.Entities;
using ScientificEvents.EF.Configurations.Relationships;

namespace ScientificEvents.EF.Contexts
{
    public class ScientificEventsContext : DbContext
    {
        public ScientificEventsContext(DbContextOptions<ScientificEventsContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Entities
            modelBuilder.ApplyConfiguration(new EventConfig());
            modelBuilder.ApplyConfiguration(new EventTypeConfig());
            modelBuilder.ApplyConfiguration(new FairConfig());
            modelBuilder.ApplyConfiguration(new ParticipationTypeConfig());
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new StandConfig());
            modelBuilder.ApplyConfiguration(new WorkConfig());

            // Aggregates
            modelBuilder.ApplyConfiguration(new EventParticipantConfig());
            modelBuilder.ApplyConfiguration(new ProductExhibitorConfig());

            // Relationships
            modelBuilder.ApplyConfiguration(new ProductAuthorshipConfig());
            modelBuilder.ApplyConfiguration(new ProductExhibitionConfig());
            modelBuilder.ApplyConfiguration(new WorkAuthorshipConfig());
            modelBuilder.ApplyConfiguration(new WorkPresentationConfig());
        }

        //Entities
        DbSet<Event> Events { get; set; }
        DbSet<EventType> EventTypes { get; set; }
        DbSet<Fair> Fairs { get; set; }
        DbSet<ParticipationType> ParticipationTypes { get; set; }
        DbSet<Person> Persons { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Stand> Stands { get; set; }
        DbSet<Work> Works { get; set; }

        // Aggregates
        DbSet<EventParticipant> EventParticipants { get; set; }
        DbSet<ProductExhibitor> ProductExhibitors { get; set; }

        //Relationships
        DbSet<ProductAuthorship> ProductAuthorships { get; set; }
        DbSet<ProductExhibition> ProductExhibitions { get; set; }
        DbSet<WorkAuthorship> WorkAuthorships { get; set; }
        DbSet<WorkPresentation> WorkPresentations { get; set; }
    }
}