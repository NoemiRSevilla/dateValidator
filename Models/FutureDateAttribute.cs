using System;
using System.ComponentModel.DataAnnotations;

namespace dateValidator.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime CurrentTime = DateTime.Now;
            if (value is DateTime)
            {

                if((DateTime)value < CurrentTime)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Date has to be before current date");
                }
            }
            return new ValidationResult("That is not a valid Date!");
        }
    }
}