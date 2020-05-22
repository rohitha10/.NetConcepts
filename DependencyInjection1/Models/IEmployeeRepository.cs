using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection1.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}
