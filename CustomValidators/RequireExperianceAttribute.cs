using System.ComponentModel.DataAnnotations;
using CustomValidation.Models;
namespace CustomValidation.CustomValidators
{
    public class RequireExperianceAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Employee employee = (Employee)validationContext.ObjectInstance;

            if ((employee.AppliedPositionName.ToUpper() != "TRAINEE" && string.IsNullOrEmpty(employee.ExperianceDetails)))
            {
                return new ValidationResult("Please enter experiance details");
            }

            return ValidationResult.Success;
        }
    }
}
