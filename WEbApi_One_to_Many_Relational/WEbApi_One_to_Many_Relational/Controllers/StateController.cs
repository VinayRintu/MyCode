using Microsoft.AspNetCore.Mvc;
using WEbApi_One_to_Many_Relational.Models;
using WEbApi_One_to_Many_Relational.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEbApi_One_to_Many_Relational.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IDataRepository<State> _repository;
        public StateController(IDataRepository<State> repository)
        {
            _repository= repository;
        }
          
        // GET: api/<StateController>
        [HttpGet]
        public IEnumerable<State> Get()
        {
           return _repository.GetAll();
        }

        // GET api/<StateController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
          var record= _repository.Get(id);

            if (record == null)
            {
                return NotFound("Record Not Found");
            }
            return Ok(record);
        }

        // POST api/<StateController>
        [HttpPost]
        public void Post([FromBody] State state)
        {
            _repository.Add(state);
        }

        // PUT api/<StateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] State state)
        {
            var record=_repository.Get(id);
            if (record == null)
            {
                NotFound("Record Not Found");
            }
            _repository.Update(record, state);
        }

        // DELETE api/<StateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record = _repository.Get(id);
            if(record == null)
            {
                NotFound("Record Not Found");
            }
            _repository.Delete(record);            
        }
    }
}
