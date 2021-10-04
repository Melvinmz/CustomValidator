using CustomValidation.CustomValidators;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomValidation.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [EmailAddress]
        [RequireContactDetails]
        public string Email { get; set; }

        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        [RequireContactDetails]
        public string Mobile { get; set; }
        [InterviewDate(ErrorMessage = "Interview date must be greater than the current date")]
        [Display(Name = "Interview Date")]
        public DateTime InterviewDate { get; set; }

        [Display(Name = "Position")]
        public IList<SelectListItem> AppliedPosition { get; set; }
        [RequireExperiance]
        [Display(Name = "Experiance Details")]
        public string ExperianceDetails { get; set; }
        [Required]
        [Display(Name = "Position")]
        public string AppliedPositionName { get; set; }

    }
}
