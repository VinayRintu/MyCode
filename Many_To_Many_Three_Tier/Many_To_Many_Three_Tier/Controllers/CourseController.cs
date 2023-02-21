using BLL.Repository;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Many_To_Many_Three_Tier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IDataRepository<Courses> _courseRepository;
        public CourseController(IDataRepository<Courses> courseRepository)
        {
            _courseRepository = courseRepository;
        }

        // GET: api/<CourseController>
        [HttpGet]
        public IEnumerable<Courses> Get()
        {
            return _courseRepository.GetAll();
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public Courses Get(int id)
        {
            var record=_courseRepository.Get(id);
            if (record == null)
            {
                NotFound("Record Not Found");
            }
            return record;
        }

        // POST api/<CourseController>
        [HttpPost]
        public void Post([FromBody] Courses course)
        {
            _courseRepository.Add(course);
        }

        // PUT api/<CourseController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Courses course)
        {
            var record=_courseRepository.Get(id);
            if(record == null)
            {
                NotFound("Record Not Found");
            }
            _courseRepository.Update(record,course);
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record = _courseRepository.Get(id);
            if (record == null)
            {
                NotFound("Record Not Found");
            }
            _courseRepository.Delete(record);
        }
    }
}
