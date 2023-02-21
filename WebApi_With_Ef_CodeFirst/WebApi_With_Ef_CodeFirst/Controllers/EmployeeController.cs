using Microsoft.AspNetCore.Mvc;
using WebApi_With_Ef_CodeFirst.Models;
using WebApi_With_Ef_CodeFirst.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi_With_Ef_CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _repository;
        public EmployeeController(IDataRepository<Employee> repository)
        {
            _repository = repository;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public  IEnumerable<Employee> Get()
        {
          return  _repository.GetAll();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var record= _repository.Get(id);
            if(record == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
           return Ok(record);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
           _repository.Add(employee);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {            
            var record=_repository.Get(id);
            if(record == null)
            {
                return NotFound("Record Not Found..");
            }
            _repository.Update(record, employee);
            return Ok("Record Updated");
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record = _repository.Get(id);
            _repository.Delete(record);
        }
    }
}
