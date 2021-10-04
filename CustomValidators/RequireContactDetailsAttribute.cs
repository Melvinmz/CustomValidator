using CustomValidation.Models;
using System.ComponentModel.DataAnnotations;
namespace CustomValidation.CustomValidators
{
    public class RequireContactDetailsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Employee employee = (Employee)validationContext.ObjectInstance;

            if (string.IsNullOrEmpty(employee.Email)  && string.IsNullOrEmpty(employee.Mobile))
            {
                return new ValidationResult("Please enter an email address or a mobile number");
            }

            return ValidationResult.Success;
        }
    }

}
