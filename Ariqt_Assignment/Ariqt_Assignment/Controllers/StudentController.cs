using BusinessLogicLayer.Repositories;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ariqt_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public async Task<IEnumerable<Student>> Get()
        {
           return await _studentRepository.GetAll();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
           var record= await _studentRepository.GetById(id);
            if(record== null)
            {
                return NotFound("Record Not Found Please Enter Correct ID");
            }
            return Ok(record);
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Student value)
        {
            await _studentRepository.Add(value);
            return Ok("Record Inserted Successfullu...");
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Student value)
        {
            var record=await _studentRepository.GetById(id);
            if(record==null)
            {
                return NotFound("Record Not Found Enter Correct Student ID");
            }
            await _studentRepository.Update(record,value);
            return Ok("Record Updated Successfully");
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
         var record= _studentRepository.GetById(id);
            if (record == null)
            {
                return NotFound("Record Not Found Enter Correct Student ID");
            }
            return Ok(record);
        }
    }
}
