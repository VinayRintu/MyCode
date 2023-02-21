using BusinessLogicLayer.Repositories;
using Data_Access_Layer.Models;
using DataAccessLayer.DbConnectionFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class CourseServices : ICourseRepository
    {
        private readonly DbContextClass? _dbContextClass;
        public CourseServices(DbContextClass? dbConnectionClass)
        {
            _dbContextClass = dbConnectionClass;
        }
        public async Task<Course> Add(Course course)
        {
            try
            {
                if (!_dbContextClass.Courses1.Any(x => x.CourseName.ToUpper() == course.CourseName.ToUpper()))
                {
                    var entity = new Course
                    {
                        CourseName = course.CourseName,
                    };
                    _dbContextClass.Add(entity);
                    await _dbContextClass.SaveChangesAsync();
                    return entity;
                }
                return null;
            }
            catch(Exception ex)
            {
               throw new Exception(ex.Message);
            }
        }

        public async Task<Course> Get(int id)
        {
            try
            {
                var record = await _dbContextClass.Courses1.FindAsync(id);
                return record;
            }
           catch(Exception ex) { throw new Exception(ex.Message);  }
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            try
            {
                return await _dbContextClass.Courses1.ToListAsync();
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task<Course> Update(Course dbentity, Course entity)
        {
            try
            {
                if (!_dbContextClass.Courses1.Any(x=>x.CourseName==entity.CourseName))
                {
                    if (entity.CourseName != "string" && entity.CourseName != null && entity.CourseName != dbentity.CourseName)
                    {
                        dbentity.CourseName = entity.CourseName;
                    }
                    await _dbContextClass.SaveChangesAsync();
                }
                return dbentity;
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }
        public async Task Delete(Course course)
        {
            try
            {
                _dbContextClass.Courses1.Remove(course);
                await _dbContextClass.SaveChangesAsync();
            }
             catch(Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
