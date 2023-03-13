#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BeltExam.Models;

public class User {
    [Key]
    public int UserId {get; set;}

    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage="must be at least 2 characters")]
    public string FirstName {get; set;}

    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage="must be at least 2 characters")]
    public string LastName {get; set;}
    
    [Required(ErrorMessage = "is required")]   
    [EmailAddress]
    [UniqueEmail]    
    public string Email {get; set;}
    
    [Required(ErrorMessage = "is required")]
    [MinLength(8, ErrorMessage="must be at least 8 characters")]
    [DataType(DataType.Password)]
    public string Password {get; set;}  

    [NotMapped]
    [Compare("Password")]
    public string PasswordConfirm {get; set;}
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public List<Post> AllPosts {get; set;} = new List<Post>();
}
public class UniqueEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if(value == null)
        {
            return new ValidationResult("Email is required!");
        }
        MyContext _context = (MyContext)validationContext.GetService(typeof(MyContext));
    	if(_context.Users.Any(e => e.Email == value.ToString()))
        {
            return new ValidationResult("Email must be unique!");
        } else {
            return ValidationResult.Success;
        }
    }
}

