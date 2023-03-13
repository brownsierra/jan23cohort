#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;

public class Dish {
    [Key]
    public int DishId {get; set;}

    [Required]
    public string Name {get; set;}

    [Required]
    [Range(1, 5, ErrorMessage = "Tastiness must be between 1 and 5")]
    public int Tastiness {get; set;}

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Calories must be greater than zero!")]
    public int Calories {get; set;}

    public int ChefId {get; set;}

    public Chef? Cook {get; set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}