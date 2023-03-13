#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BeltExam.Models;

public class Post {
    [Key]
    public int PostId {get; set;}
    [Required]
    public string Title {get; set;}
    [Required]
    public string Img {get; set;}
    [Required]
    public string Medium {get; set;}
    [Required]
    public bool ForSale {get; set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
    public int UserId {get; set;}
    public User? Author {get; set;}
    public List<Post> AllPosts {get; set;} = new List<Post>();

}
