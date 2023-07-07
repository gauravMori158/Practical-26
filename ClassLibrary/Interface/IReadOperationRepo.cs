using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interface
{
    public interface IReadOperationRepo
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeById(int? id);
    }
}
