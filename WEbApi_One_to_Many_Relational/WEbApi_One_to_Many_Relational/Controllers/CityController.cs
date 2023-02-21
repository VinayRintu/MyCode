using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using WEbApi_One_to_Many_Relational.Models;
using WEbApi_One_to_Many_Relational.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEbApi_One_to_Many_Relational.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IDataRepository<City> _repository;
        public CityController(IDataRepository<City> repository)
        {
            _repository = repository;
        }

        // GET: api/<CityController>
        [HttpGet]
        public IEnumerable<City> Get()
        {
            return _repository.GetAll();
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
          var record = _repository.Get(id);
            if (record == null)
            {
               return NotFound("Record Not Found");
            }
            return Ok(record);
        }

        // POST api/<CityController>
        [HttpPost]
        public void Post([FromBody] City city)
        {
            _repository.Add(city);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] City city)
        {
            var record = _repository.Get(id);
            if (record == null)
            {
                NotFound("Record Not Found");
            }
            _repository.Update(record, city);
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record=_repository.Get(id);
            if (record == null)
            {
                NotFound("Record Not Found");
            }
            _repository.Delete(record);
        }
    }
}
