using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AM.ApplicationCore.Domain;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            // Relation one-to-many Flight -> Plane
            builder.HasOne(f => f.Plane)
                   .WithMany(p => p.Flights)
                   .HasForeignKey(f => f.PlaneId);

            // Relation many-to-many Flight <-> Passenger
            builder.HasMany(f => f.Passengers)
                   .WithMany(p => p.Flights)
                   .UsingEntity(t=> t.ToTable("Reservation")); // Table de jonction personnalisée
        }
    }
}