using BusinessLogicLayer.Repositories;
using DataAccessLayer.DbContextFolder;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class courseServices : ICourseRepository
    {
        private readonly DbContextClass? _dbContextClass;
        public courseServices(DbContextClass? dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<Course> Add(Course entity)
        {
            if (!_dbContextClass.Courses2.Any(x => x.CourseName.ToUpper() == entity.CourseName.ToUpper()))
            {
                var course = new Course
                {
                    CourseName = entity.CourseName,
                };
                _dbContextClass.Courses2.Add(course);
                await _dbContextClass.SaveChangesAsync();
                return course;
            }
            else
            {
                return null;
            }
        }

        public async Task Delete(Course entity)
        {
             _dbContextClass.Courses2.Remove(entity);
           await _dbContextClass.SaveChangesAsync();
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            return await _dbContextClass.Courses2.ToListAsync();
        }

        public async Task<Course> GetById(int id)
        {
            var record = await _dbContextClass.Courses2.FindAsync(id);
            return record;
        }

        public async Task Update(Course dbentity, Course entity)
        {
            dbentity.CourseName = entity.CourseName;
            await _dbContextClass.SaveChangesAsync();
        }
    }
}
