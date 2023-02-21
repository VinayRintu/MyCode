using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vinay__CI_CD__New.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VinayController : ControllerBase
    {
        // GET: api/<VinayController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VinayController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VinayController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VinayController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VinayController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
