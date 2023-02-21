using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using StatesWebAPI.DataBase;
using StatesWebAPI.Models;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StatesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class StateController : ControllerBase
    {        
        private readonly Dbcontext dbcontext;
        public StateController(Dbcontext _dbcontext)
        {
            dbcontext = _dbcontext;
        }
        
        [HttpGet]
        public IEnumerable<State> Get()
        {
            return dbcontext.States.ToList();
        }
       
        [HttpGet("{id}")]
        public State Get( int id)
        {
           var record =  dbcontext.States.Find(id);
            return record;
        }
        
        [HttpPost]
        public void Post([FromBody] State newrecord)
        {
            dbcontext.States.Add(newrecord);
            dbcontext.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] State newrecord)
        {
            var record= dbcontext.States.Find(id);
            if (record != null)
            {
                record.CM = newrecord.CM;
                dbcontext.SaveChanges();
            }
            //dbcontext.States.Find(id).CM=newrecord.CM;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          var record= dbcontext.States.Find(id);
            if (record != null)
            {
                dbcontext.States.Remove(record);
                dbcontext.SaveChanges();
            }
        }
        [HttpGet("{stateName}")]
        public State GetCm(string stateName)
        {
          var record=  dbcontext.States.Find(stateName);
            return record;
        }
        
    }
}
