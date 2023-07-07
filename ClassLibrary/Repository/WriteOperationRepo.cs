using ClassLibrary.Interface;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
    public class WriteOperationRepo : IWriteOperationRepo
    {
        private readonly ApplicationDbContext context;
        public WriteOperationRepo(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public void CreateEmployee(Employee employee)
        {
             context.Employees.Add(employee);   
             context.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var  employee = context.Employees.FirstOrDefault(e => e.Id == id);
            employee.Status = false;
            context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        { 
            context.Employees.Update(employee); 
            context.SaveChanges();
        }
    }
}
