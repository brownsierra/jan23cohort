#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models;

public class Dish {
    [Key]
    [Required]
    public int DishId {get; set;}

    [Required]
    public string Name {get; set;}

    [Required]
    public string Chef {get; set;}

    [Required]
    [Range(1, 5, ErrorMessage = "Must be between 1 and 5")]
    public int Tastiness {get; set;}

    [Required]
    [Range(1, Int32.MaxValue, ErrorMessage = "Must be greater than 0 calories!")]
    public int Calories {get; set;}

    [Required]
    public string Description {get; set;}

    [Required]
    public DateTime CreatedAt {get; set;} = DateTime.Now;

    [Required]
    public DateTime UpdatedAt {get; set;} = DateTime.Now;    
}