using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection1.Models
{
    public class MockEmployeeRepository:IEmployeeRepository
    {
        private List<Employee> employees;
        public MockEmployeeRepository()
        {
            employees = new List<Employee>()
            {
                new Employee(){Id = 1,Name = "Rohi",Email = "rc@gmail.com", Department = "CSE"},
                new Employee(){Id = 2,Name = "Sumanth",Email = "sc@gmail.com", Department = "B.sc.Computers"}

            };
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
