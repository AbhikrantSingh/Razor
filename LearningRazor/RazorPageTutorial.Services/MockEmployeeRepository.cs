using RazorLearningTutorials;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPageTutorial.Services
{
   public  class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> emp_list;

        public MockEmployeeRepository()
        {
            emp_list = new List<Employee>()
            {
                new Employee(){Id=1,Name="Abhi",Deparment=Dept.HR,Email="abhi@gmail.com",PhotoPath="abhi.jpg" },
                new Employee(){Id=2,Name="Abhi2",Deparment=Dept.None,Email="abhi2@gmail.com",PhotoPath="abhi.jpg" },
                new Employee(){Id=3,Name="Abh3",Deparment=Dept.Payroll,Email="abhi3@gmail.com",PhotoPath="abhi.jpg" },
                new Employee(){Id=4,Name="Abhi5",Deparment=Dept.IT,Email="abhi5@gmail.com",PhotoPath="abhi.jpg" },

            };
        }



        public IEnumerable<Employee> getAllEmployee()
        {
            return emp_list;
        }
    }
}
