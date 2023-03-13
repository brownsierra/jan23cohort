#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;
/****ADD DATE OF BIRTH VALIDATION****/
public class Chef {
    [Key]
    public int ChefId {get; set;}

    [Required]
    public string FirstName {get; set;}

    [Required]
    public string LastName {get; set;}

    [Required]
    [OverEighteen]
    [FutureDate]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth {get; set;}

    public List<Dish> AllDishes {get; set;} = new List<Dish>();
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

            public static int CalculateAge(DateTime DateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
            {
            age--;
            }
            return age;
        }
    
}

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if(((DateTime)value) >= DateTime.Now.Date){
            return new ValidationResult("Date entered must before today's date");
        }else{
            return ValidationResult.Success;
        }
    }
}

public class OverEighteenAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        int year = DateTime.Now.Year - ((DateTime)value).Year;
        if((((DateTime)value).Month > DateTime.Now.Month) || (((DateTime)value).Month == DateTime.Now.Month && ((DateTime)value).Day > DateTime.Now.Day)){
            year--;
        }
        if(year < 18){
            return new ValidationResult("Must be older than 18");
        }else{
            return ValidationResult.Success;
        }
        // You first may want to unbox "value" here and cast to to a DateTime variable!
    }
}