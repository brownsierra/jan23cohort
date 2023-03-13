#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SoloProject.Models;

public class Cupcake {
    [Key]
    public int CupcakeId {get; set;}
    public string Name {get; set;}
    
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}