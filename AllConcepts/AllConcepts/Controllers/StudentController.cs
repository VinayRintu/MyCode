using Business_Logic_Layer.Repository;
using Business_Logic_Layer.Services;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AllConcepts.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IGetRepository<Student>? _repository;
        private readonly IUpdateRepository<Student>? _updateRepository;
        private readonly IAddDeleteRepository<Student>? _adddeleteRepository;
        public StudentController(IGetRepository<Student>? studentRepository, IAddDeleteRepository<Student>? deleteRepository,IUpdateRepository<Student> updateRepository)
        {
            _repository = studentRepository;
            _adddeleteRepository = deleteRepository;
            _updateRepository = updateRepository;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _repository.GetAll();
        }

        // GET api/<StudentController>/5
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

        // POST api/<StudentController>
        [HttpPost]
        public IActionResult Post([FromBody] Student student)
        {
            _adddeleteRepository.Add(student);
            return Ok("Record Inserted Successfully");
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Student student)
        {
            var record = _repository.Get(id);
            if (record == null)
            {
                return NotFound("Record No Found Please Enter Valid Record ID");
            }
            _updateRepository.Update(record, student);
            return Ok("Record Successfully Updated");
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var record = _repository.Get(id);
            if (record == null)
            {
                return NotFound("Record No Found Please Enter Valid Record ID");
            }
            _adddeleteRepository.Delete(record);
            return Ok("Record Deleted Successfully");
        }
    }
}
