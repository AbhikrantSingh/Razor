using RazorLearningTutorials;
using System;
using System.Collections.Generic;

namespace RazorPageTutorial.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> getAllEmployee();



    }
}
