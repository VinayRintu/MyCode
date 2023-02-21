using BLL.Repository;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Many_To_Many_Three_Tier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IDataRepository<Students> _studentsRepository;
        public StudentsController(IDataRepository<Students> studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Students> Get()
        {
            return _studentsRepository.GetAll();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Students Get(int id)
        {
            var record=_studentsRepository.Get(id);
            if(record == null)
            {
                NotFound("Record Not Found");
            }
                return record;           
           
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Students students)
        {
            _studentsRepository.Add(students);
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Students student)
        {
            var record= _studentsRepository.Get(id);
            if (record == null)
            {
                NotFound("Record Not Found");
            }
            else
            {
                _studentsRepository.Update(record, student);
            }
            
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record=_studentsRepository.Get(id);
            if (record == null)
            {
                NotFound("Record Not Found");                
            }
            else
            {
                _studentsRepository.Delete(record);
            }
            //_studentsRepository.Delete(record);
        }
    }
}
