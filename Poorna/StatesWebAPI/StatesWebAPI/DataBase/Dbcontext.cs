using Microsoft.EntityFrameworkCore;
using StatesWebAPI.Models;

namespace StatesWebAPI.DataBase
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions options):base(options) 
        { 
        }                        
        public DbSet<State> States { get; set; }
    }
}
