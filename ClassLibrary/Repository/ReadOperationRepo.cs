using ClassLibrary.Interface;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
    public class ReadOperationRepo : IReadOperationRepo
    {
        private   readonly ApplicationDbContext context;
        public ReadOperationRepo(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public Employee GetEmployeeById(int? id)
        {
            return context.Employees.Where(e=>e.Status == true).FirstOrDefault(e=>e.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return context.Employees.Where(e => e.Status == true).ToList();
        }
    }
}
