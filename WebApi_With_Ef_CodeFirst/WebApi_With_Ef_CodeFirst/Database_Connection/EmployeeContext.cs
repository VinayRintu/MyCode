using Microsoft.EntityFrameworkCore;
using WebApi_With_Ef_CodeFirst.Models;

namespace WebApi_With_Ef_CodeFirst.Database_Connection
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
