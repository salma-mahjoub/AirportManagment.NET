using Microsoft.EntityFrameworkCore;
using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;

namespace AM.Infrastructure.Data
{
    public class AMContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Traveller> Travellers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;port=3306;database=AirportManagementDB;user=root;password=";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        //Fluent API configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Appel aux configurations
            //1ère méthode 
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());

            

        }
        //Préconvention : appliquer la configuration à toutes les propriétés de type DateTime

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            // Appliquer le type SQL "date" à toutes les propriétés DateTime
            configurationBuilder.Properties<DateTime>()
                                .HaveColumnType("date");
        }
    }
}