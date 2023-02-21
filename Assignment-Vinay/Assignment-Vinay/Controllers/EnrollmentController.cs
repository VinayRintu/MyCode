using BusinessLogicLayer.Repositories;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_Vinay.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentRepository? _Services;
        public EnrollmentController(IEnrollmentRepository? services)
        {
            _Services = services;
        }
        // GET: api/<EnrollmentController>
        [AllowAnonymous]
        [HttpGet]
        public async Task<IEnumerable<Enrollments>> Get()
        {
            try
            {
                return await _Services.GetAll();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        // GET api/<EnrollmentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var record = await _Services.GetById(id);
                if (record == null)
                {
                    return NotFound();
                }
                return Ok(record);
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        // POST api/<EnrollmentController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Enrollments value)
        {
            try
            {
                var enroll = await _Services.Add(value);
                if (enroll == null)
                {
                    return Ok("Entered Records Not Exist in Student & Course Tables Please Check Once and Enter Again..");
                }
                else if (enroll.EnrollmentID == 1)
                {
                    return Ok("Enter new courseID because the Student already have that Course..");
                }
                return Ok(enroll);
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        // PUT api/<EnrollmentController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Enrollments value)
        {
            try
            {
                var record = await _Services.GetById(id);
                if (record == null)
                {
                    return NotFound(id);
                }
                await _Services.Update(record, value);
                return Ok(value);
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        // DELETE api/<EnrollmentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var record = await _Services.GetById(id);
                if (record == null)
                {
                    return NotFound("Record Not Found Of : " + id);
                }
                await _Services.Delete(record);
                return Ok("Record Deleted For Id : " + id);
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
