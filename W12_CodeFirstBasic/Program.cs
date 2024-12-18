using W12_CodeFirstBasic.Data;

namespace W12_CodeFirstBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Testing W12_CodeFirstBasic...");

        using var context = new PatikaFirstDbContext();
        Console.WriteLine("Games:");
        foreach (var game in context.Games)
        {
            Console.WriteLine($"{game.Id} - {game.Name} - {game.Platform} - {game.Rating}");
        }

        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("Movies:");
        foreach (var movie in context.Movies)
        {
            Console.WriteLine($"{movie.Id} - {movie.Title} - {movie.Genre} - {movie.ReleaseYear}");
        }
        
        Console.ReadKey();
    }
}

