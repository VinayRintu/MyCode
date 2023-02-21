using Key_Vault.Models;
using Microsoft.EntityFrameworkCore;

namespace Key_Vault.DbConnection
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions options):base(options) { }
        
        public DbSet<Customer> Customers { get; set; }
    }
}
