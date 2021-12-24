using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorLearningTutorials;
using RazorPageTutorial.Services;

namespace LearningRazor.Pages.Employess
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;
        public IEnumerable<Employee> Employess { get; set; }
        public IndexModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public void OnGet()
        {
            Employess = employeeRepository.getAllEmployee();
        }
    }
}
