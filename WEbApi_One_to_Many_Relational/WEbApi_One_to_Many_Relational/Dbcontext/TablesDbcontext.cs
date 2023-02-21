using Microsoft.EntityFrameworkCore;
using WEbApi_One_to_Many_Relational.Models;

namespace WEbApi_One_to_Many_Relational.Dbcontext
{
    public class TablesDbcontext : DbContext
    {
        public TablesDbcontext(DbContextOptions options):base(options)
        {

        }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
