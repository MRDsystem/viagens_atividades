using Journey.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Journey.Infrastructure
{
    public class JourneyDbContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; } //Trip, classe que representa a tabela. Trips o nome da tabela (como está no banco)
        public DbSet<Activity> Activities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = C:\\Users\\marcelo.david.ext\\Documents\\dev\\Journey\\db\\JourneyDatabase.db");
        }
    }
}
