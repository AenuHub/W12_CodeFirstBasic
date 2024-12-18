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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(
            new Movie() { Id = 1, Title = "The Shawshank Redemption", Genre = "Drama", ReleaseYear = 1994 },
            new Movie() { Id = 2, Title = "The Godfather", Genre = "Crime", ReleaseYear = 1972 },
            new Movie() { Id = 3, Title = "The Dark Knight", Genre = "Action", ReleaseYear = 2008 },
            new Movie() { Id = 4, Title = "12 Angry Men", Genre = "Drama", ReleaseYear = 1957 }
        );

        modelBuilder.Entity<Game>().HasData(
            new Game() { Id = 1, Name = "Counter-Strike: Global Offensive", Platform = "PC", Rating = 4.3m },
            new Game() { Id = 2, Name = "Grand Theft Auto V", Platform = "PC", Rating = 4.5m },
            new Game() { Id = 3, Name = "The Legend of Zelda: Breath of the Wild", Platform = "Nintendo Switch", Rating = 4.1m },
            new Game() { Id = 4, Name = "The Witcher 3: Wild Hunt", Platform = "PC", Rating = 3.6m },
            new Game() { Id = 5, Name = "The Last of Us Part II", Platform = "PS4", Rating = 4.4m },
            new Game() { Id = 6, Name = "World of Warcraft", Platform = "PC", Rating = 4.9m }
        );
    }   
}