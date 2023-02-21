using BusinessLogicLayer.Repository;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThreeTier_With_JWT_Authentication.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _employeeRepository;
        public EmployeeController(IDataRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
           return _employeeRepository.GetAll();
        }
        //comment
        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
           var record= _employeeRepository.Get(id);
            if (record == null)
            {
                NotFound("Record Not Found");
            }
            return record;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee emp)
        {
            _employeeRepository.Add(emp);
        }
        
    }
}
