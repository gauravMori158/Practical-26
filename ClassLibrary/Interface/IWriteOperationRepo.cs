using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Interface
{
    public interface IWriteOperationRepo
    {
        void UpdateEmployee(Employee employee);
        void CreateEmployee(Employee employee);
        void DeleteEmployee(int id);
    }
}
