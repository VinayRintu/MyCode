using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Practice_MSAL.Model;
using Practice_MSAL.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Practice_MSAL.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MsalController : ControllerBase
    {
        private readonly IDataRepository<Msal_Class> _dataRepository;
        public MsalController(IDataRepository<Msal_Class> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/<MsalController>
        [HttpGet]
        public IEnumerable<Msal_Class> Get()
        {
           return _dataRepository.GetAll();
        }

        // GET api/<MsalController>/5
        [HttpGet("{id}")]
        public Msal_Class Get(int id)
        {
            var record= _dataRepository.Get(id);
            return record;
        }

        // POST api/<MsalController>
        [HttpPost]
        public void Post([FromBody] Msal_Class value)
        {
            _dataRepository.Add(value);
        }

        // PUT api/<MsalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Msal_Class value)
        {
            var record = _dataRepository.Get(id);
            _dataRepository.Update(record, value);
        }

        // DELETE api/<MsalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var record = _dataRepository.Get(id);
            _dataRepository.Delete(record);
        }
    }
}
