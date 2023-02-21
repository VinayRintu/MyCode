using BusinessLogicLayer.Repositories;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;


namespace Ariqt_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;
        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        // GET: api/<CourseController>
        [HttpGet]
        public async Task<IEnumerable<Course>> Get()
        {
           return await _courseRepository.GetAll();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var record=await _courseRepository.GetById(id);
            if(record!=null)
            {
                return NotFound("Record Not Found Please Enter Correct ID");
            }
            return Ok(record);
        }

        // POST api/<CourseController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Course value)
        {
           var record= await _courseRepository.Add(value);
            if(record==null)
            {
                return Ok("Enter Unique Course name..");
            }
            return Ok(record);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Course value)
        {
            var record=await _courseRepository.GetById(id);
            if(record!=null)
            {
                return NotFound("Record Not Found Enter Correct Course ID");
            }
            return Ok("Record Updated Successfully");
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var record = await _courseRepository.GetById(id);
            if(record == null)
            {
                return NotFound("Record Not Found Enter Valid Record ID");
            }
            return Ok(record);
        }
    }
}
