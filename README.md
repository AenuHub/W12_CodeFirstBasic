## W12_CodeFirstBasic

This project is a console application that uses Entity Framework Core to create a database using the Code First approach. This database has two tables: `Movies` and `Games`.

The `Movies` table has the following columns:

* `Id`: int, primary key and auto-incrementing.
* `Title`: string, the title of the movie.
* `Genre`: string, the genre of the movie (e.g. "Action", "Comedy", "Drama").
* `ReleaseYear`: int, the year the movie was released.

The `Games` table has the following columns:

* `Id`: int, primary key and auto-incrementing.
* `Name`: string, the name of the game.
* `Platform`: string, the platform the game is played on (e.g. "PC", "PlayStation", "Xbox").
* `Rating`: decimal, the rating of the game (between 0 and 10).

The database context class is named `PatikaFirstDbContext`. The database name is `PatikaCodeFirstDb1`. The two tables in the database are `Movies` and `Games`.

`Program.cs` file and hard coded connection string is solely used for testing, not for production.