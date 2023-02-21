using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.TablesDbContext
{
    public class DbcontextClass : DbContext
    {
        public DbcontextClass(DbContextOptions options) : base(options) 
        { }
        public DbSet<Students> Studentss { get; set; }
        public DbSet<Courses> Coursess { get; set; }
        public DbSet<Enrollments> Enrollmentss { get; set; }
    }
}
