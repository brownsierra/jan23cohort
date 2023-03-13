#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyWValidations.Models;

public class DojoStudent
{
    [Required]
    [MinLength(2, ErrorMessage = "You must provide your name!")]
    public string Name {get;set;}
    [Required(ErrorMessage = "You must provide your location!")]
    public string Location {get; set;}
    [Required (ErrorMessage = "You must tell us your fav language!")]
    public string FavLang {get;set;}
    [MinLength(20, ErrorMessage = "Your comment must be at least 20 characters long!")]
    public string Comment {get; set;}
}
