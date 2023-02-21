using BusinessLogicLayer.Repositories;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using System.Xml.Linq;


namespace Assignment_Vinay.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;
        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
       
        [HttpGet]
        [AllowAnonymous]
        public async Task<IEnumerable<Course>> GetAll()
        {
            try
            {
                return await _courseRepository.GetAll();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            try
            {
                var record = await _courseRepository.Get(id);
                if (record == null)
                {
                    return NotFound("Record Not Found Enter Correct ID");
                }
                //return Ok(record);
                return Ok(record);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Course value)
        {
            try
            {
                var record = await _courseRepository.Add(value);
                if (record == null)
                {
                    return NotFound("The Course Name Already Exist Please Enter New Course Name..");
                }
                return Ok(record);
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }
       
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Course value)
        {
            try
            {
                var record = await _courseRepository.Get(id);
                if (record == null)
                {
                    return NotFound("Record Not Found Please Enter Valid Record ID");
                }
                var updatedRecord = await _courseRepository.Update(record, value);
                if(updatedRecord.CourseName == "NoData")
                {
                    return Ok("Course Name Already Exists In The Table Try To Update Again..");
                }
                return Ok(updatedRecord);
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var record = await _courseRepository.Get(id);
                if (record == null)
                {
                    return NotFound("Enter Valid CourseID to Delete...");
                }
                await _courseRepository.Delete(record);
                return Ok("Record Deleted Of This ID: " + id);
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
