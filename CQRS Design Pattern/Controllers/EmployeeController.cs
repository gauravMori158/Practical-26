using ClassLibrary.Interface;
using ClassLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Design_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IReadOperationRepo _readOperationRepo;
        private readonly IWriteOperationRepo _writeOperationRepo;
        public EmployeeController(IReadOperationRepo readOperationRepo , IWriteOperationRepo writeOperationRepo)
        {
            _readOperationRepo = readOperationRepo;
            _writeOperationRepo = writeOperationRepo;
                
        }
        [HttpGet]
        public IActionResult GetEmployee(int? id)
        {
            if (id == null)
                return Ok(_readOperationRepo.GetEmployees());
            else
                return Ok(_readOperationRepo.GetEmployeeById(id));
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _writeOperationRepo.CreateEmployee(employee);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(int id , Employee employee) 
        { 
            if(id !=employee.Id)
            {
                return BadRequest();
            }

            else
            {
                _writeOperationRepo.UpdateEmployee(employee);
                return Ok();
            }
        
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _writeOperationRepo.DeleteEmployee(id);
            return Ok();
        }
    }
}
