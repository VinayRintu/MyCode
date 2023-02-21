using Business_Logic_Layer.Repository;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllConcepts.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CourceController : ControllerBase
    {
        private readonly IGetRepository<Course> _repository;
        private readonly IAddDeleteRepository<Course> _adddeleteRepository;
       
        
        public CourceController(IGetRepository<Course> courseRepository, IAddDeleteRepository<Course> deleteRepository)
        {
            _repository= courseRepository;
            _adddeleteRepository= deleteRepository;
           
        }
        // GET: api/<CourceController>
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _repository.GetAll();
        }

        // GET api/<CourceController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var record = _repository.Get(id);
            if (record == null)
            {
                return NotFound("Record Not Found Enter Correct ID");
            }
            return Ok(record);
        }

        // POST api/<CourceController>
        [HttpPost]
        public IActionResult Post([FromBody] Course course)
        {
            _adddeleteRepository.Add(course);
            return Ok("Record Inserted Successfully");
        }

        // DELETE api/<CourceController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var record= _repository.Get(id);
            if(record== null)
            {
                return NotFound("Record Not Found Enter Correct ID");
            }
            _adddeleteRepository.Delete(record);
            return Ok("Record Deleted Successfully");
        }
    }
}
