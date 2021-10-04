using System;
using System.ComponentModel.DataAnnotations;

namespace CustomValidation.CustomValidators
{
    public class InterviewDateAttribute:ValidationAttribute
    {
        public override bool IsValid(object value)
        {            
            return Convert.ToDateTime(value).Date > DateTime.Today;
        }
    }
}
