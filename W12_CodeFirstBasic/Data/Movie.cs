using System.ComponentModel.DataAnnotations;

namespace W12_CodeFirstBasic.Data;

public class Movie
{
    [Required]
    public int Id { get; set; }

    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    [MaxLength(100)]
    public string Genre { get; set; } = string.Empty;

    // e.g 1900 - 2024
    [CurrentYearRange(1900)]
    public int ReleaseYear { get; set; }
}

// custom validation for release year attribute checking between int min and current year
public class CurrentYearRangeAttribute(int min) : RangeAttribute(min, DateTime.Now.Year);