using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCrud.Data;

namespace WebApiCrud.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ApiDbContext dbcontext;

        public ContactsController(ApiDbContext _dbcontext)
        {
            dbcontext = _dbcontext;
        }

        [HttpGet]
        public async Task<IActionResult> GetContacts()
        {
            return Ok( await dbcontext.Contacts.ToListAsync());
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetContact([FromRoute] Guid id)
        {

        }
    }
}
