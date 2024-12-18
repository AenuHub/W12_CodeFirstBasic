using System.ComponentModel.DataAnnotations;

namespace W12_CodeFirstBasic.Data;

public class Game
{
    [Required]
    public int Id { get; set; }
    
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    
    [MaxLength(100)]
    public string Platform { get; set; } = string.Empty;
    
    [Range(0, 10)]
    public decimal Rating { get; set; }
}