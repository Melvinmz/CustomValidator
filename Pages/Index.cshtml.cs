using CustomValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomValidation.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public Employee Employee { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Employee = new Employee();
            Employee.InterviewDate = DateTime.Today;
            Employee.AppliedPosition = GetPositions();

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Employee.AppliedPosition = GetPositions();
                return Page();
            }
            return RedirectToPage("/Success");

        }
        public List<SelectListItem> GetPositions()
        {
            return new List<SelectListItem>
       {
             new SelectListItem {Text = "--Select--", Value = string.Empty},
            new SelectListItem {Text = "Manager", Value = "Manager"},
            new SelectListItem {Text = "Assistant Manager", Value = "Assistant Manager"},
             new SelectListItem {Text = "Team Leader", Value = "Team Leader"},
              new SelectListItem {Text = "Trainee", Value = "Trainee"},
       };


        }

    }
}
