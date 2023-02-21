using Business_Logic_Layer.Repository;
using Data_Access_Layer.DbContextFolder;
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services
{
    public class CourseServices : IGetRepository<Course>,IAddDeleteRepository<Course>
    {
        private readonly DbContextClass? _dbContextClass;
        public CourseServices(DbContextClass? dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public void Add(Course city)
        {
            var entity = new Course
            {
                CourseID = city.CourseID,
                CourseName = city.CourseName,
                StudentID = city.StudentID,
            };
            _dbContextClass.Add(entity);
            _dbContextClass.SaveChanges();
        }

        public void Delete(Course entity)
        {
            _dbContextClass.Courses.Remove(entity);
            _dbContextClass.SaveChanges();
        }

        public Course Get(int id)
        {
            var record = _dbContextClass.Courses.Find(id);
            return record;
        }

        public IEnumerable<Course> GetAll()
        {           
            return _dbContextClass.Courses.Include(x=>x.Student).ToList();
        }   
        
        //public IEnumerable<Course> GetOnlyCourses()
        //{
        //    return _dbContextClass.Courses.ToList();
        //}
    }
}
