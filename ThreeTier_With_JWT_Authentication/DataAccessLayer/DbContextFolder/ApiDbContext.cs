using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbContextFolder
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options):base(options)
        { }
        public DbSet<AuthenticatedResponse> authenticatedResponses { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<LoginModel> loginModels { get; set; }

    }
}
