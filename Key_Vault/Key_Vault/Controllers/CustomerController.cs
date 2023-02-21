using Key_Vault.Models;
using Key_Vault.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Key_Vault.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IDataRepository<Customer> _repository;

        public CustomerController(IDataRepository<Customer> repository)
        {
            _repository = repository;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _repository.GetAll();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var record= _repository.Get(id);
            if (record == null)
            {
                return NotFound("The Customer record couldn't be found.");
            }
            return Ok(record);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer customer)
        {
            _repository.Add(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer customer)
        {
            var record=_repository.Get(id);
            _repository.Update(record, customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record = _repository.Get(id);
            _repository.Delete(record);
        }
    }
}
