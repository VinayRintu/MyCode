using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbContextFolder
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions options):base (options)
        {

        }
        public DbSet<Student> Students2 { get; set; }
        public DbSet<Course> Courses2 { get; set; }
        public DbSet<Enrollments> Enrollments2 { get; set; }
    }
}
