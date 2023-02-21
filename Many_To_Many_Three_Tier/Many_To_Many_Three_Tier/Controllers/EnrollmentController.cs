using BLL.Repository;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Many_To_Many_Three_Tier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly IDataRepository<Enrollments> _dataRepository;
        public EnrollmentController(IDataRepository<Enrollments> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/<EnrollmentController>
        [HttpGet]
        public IEnumerable<Enrollments> Get()
        {
           return _dataRepository.GetAll();
        }

        // GET api/<EnrollmentController>/5
        [HttpGet("{id}")]
        public Enrollments Get(int id)
        {
            Enrollments record= _dataRepository.Get(id);
            return record;
        }

        // POST api/<EnrollmentController>
        [HttpPost]
        public void Post([FromBody] Enrollments enrollment)
        {
            _dataRepository.Add(enrollment);
        }

        // PUT api/<EnrollmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Enrollments enrollment)
        {
            var record = _dataRepository.Get(id);
            if(record==null)
            {
                NotFound("Record Not Found");
            }
            _dataRepository.Update(record, enrollment);
        }

        // DELETE api/<EnrollmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record = _dataRepository.Get(id);
            if(record==null)
            {
                NotFound("Record Not Found");
            }
            _dataRepository.Delete(record);
        }
    }
}
