#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BeltExam.Models;

public class PostsAndUsers {
    public Post? Post {get; set;}
    public List<Post> AllPosts {get; set;}
    public User? User {get; set;}
    public List<User> AllUsers {get; set;}

}