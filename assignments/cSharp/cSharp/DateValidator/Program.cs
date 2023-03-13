public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // You first may want to unbox "value" here and cast to to a DateTime variable!
        DateTime dati;
        if(value is DateTime)
        {
            dati = (DateTime)value;
        }
        else
        {
            return new ValidationResult("This is an invalid DateTime");
        }
        if(dati < DateTime.Now)
        {
            return new ValidationResult("Date must be in the future!");
        }
        return ValidationResult.success;
    }
}

