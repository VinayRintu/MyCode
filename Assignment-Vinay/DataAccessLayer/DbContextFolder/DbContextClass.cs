using Data_Access_Layer.Models;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbConnectionFolder
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students1 { get; set; }
        public DbSet<Course> Courses1 { get; set;}
        public DbSet<Enrollments> Enrollments1 { get; set; }
    }
}
