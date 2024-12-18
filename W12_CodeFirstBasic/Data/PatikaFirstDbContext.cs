using Microsoft.EntityFrameworkCore;

namespace W12_CodeFirstBasic.Data;

public class PatikaFirstDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public DbSet<Game> Games { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // not the best practice to use hard coded connection string
        // added test database connection string for learning purposes
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5432;Database=PatikaCodeFirstDb1;Username=postgres;Password=6330");
    }
}