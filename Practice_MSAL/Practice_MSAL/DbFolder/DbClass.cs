using Microsoft.EntityFrameworkCore;
using Practice_MSAL.Model;

namespace Practice_MSAL.DbFolder
{
    public class DbClass : DbContext
    {
        public DbClass(DbContextOptions options):base(options)
        {

        }
        public DbSet<Msal_Class> MsalClasses { get; set; } 
    }
}
