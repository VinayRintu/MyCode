using BusinessLogicLayer.Repositories;
using BusinessLogicLayer.Services;
using DataAccessLayer.DbContextFolder;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ariqt_Assignment.Controllers
{
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
        [HttpGet]
        public async Task<IEnumerable<Enrollments>> Get()
        {
           return await _Services.GetAll();
        }

        // GET api/<EnrollmentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var record =await _Services.GetById(id);
            if(record == null)
            {
                return NotFound();
            }
            return Ok(record);
        }

        // POST api/<EnrollmentController>
        [HttpPost]        
        public async Task<IActionResult> Post([FromBody] Enrollments value)
        {
           var enrollID= await _Services.Add(value);
            if(enrollID == null)
            {
                return Ok("Entered Records Not Exist Please Check Once and Enter Again..");
            }
           return Ok(enrollID);
        }

        // PUT api/<EnrollmentController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Enrollments value)
        {
            var record = await _Services.GetById(id);
            if(record == null)
            {
                 return NotFound(id);        
            }
             await _Services.Update(record, value);
            return Ok(value);
        }

        // DELETE api/<EnrollmentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var record = await _Services.GetById(id);
            if(record == null)
            {
                return NotFound("Record Not Found Of : "+id);
            }
            await _Services.Delete(record);
            return Ok(record);
        }
    }
}
