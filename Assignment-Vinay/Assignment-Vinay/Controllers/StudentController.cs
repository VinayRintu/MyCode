using BusinessLogicLayer.Repositories;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_Vinay.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<StudentController> _logger;

        public StudentController(IStudentRepository studentRepository, ILogger<StudentController> logger) 
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }

        // GET: api/<StudentController>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<Student>> GetAll()
        {
            try
            {
                _logger.LogDebug("Error From GetAll method from Student Controller");
                return await _studentRepository.GetAll();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var record = await _studentRepository.Get(id);
                if (record == null)
                {
                    return NotFound("Record Not Found Enter Correct ID");
                }
                return Ok(record);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Student value)
        {
            try
            {
                var record = await _studentRepository.Add(value);
                return Ok(record);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Student value)
        {
            try
            {
                var record = await _studentRepository.Get(id);
                if (record == null)
                {
                    return NotFound("Record No Found Please Enter Valid Record ID");
                }
                await _studentRepository.Update(record, value);
                return Ok(value);
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var record = await _studentRepository.Get(id);
                if (record == null)
                {
                    return NotFound("Record Not Found Please Enter Valid Record ID");
                }
                await _studentRepository.Delete(record);
                return Ok("Record Deleted Sucessfully Of :" + id);
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
