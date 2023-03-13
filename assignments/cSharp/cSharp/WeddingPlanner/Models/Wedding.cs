#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace WeddingPlanner.Models;

public class Wedding {
    [Key]
    public int WeddingId {get; set;}

    [Required]
    public string WedderOne {get; set;}

    [Required]
    public string WedderTwo {get; set;}

    [Required]
    [FutureDate]
    public DateTime WeddingDate {get; set;}

    [Required]
    public string Address {get; set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public List<WeddingAttendance> Attendees {get; set;} = new List<WeddingAttendance>();

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