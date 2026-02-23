using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AM.ApplicationCore.Domain;

namespace AM.Infrastructure.Configurations
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            // Clé primaire
            builder.HasKey(p => p.PlaneId);

            // Nom de la table
            builder.ToTable("MyPlanes");

            // Renommer la colonne Capacity
            builder.Property(p => p.Capacity)
                   .HasColumnName("PlaneCapacity");
        }
    }
}