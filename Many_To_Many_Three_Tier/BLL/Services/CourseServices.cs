using BLL.Repository;
using DAL.Models;
using DAL.TablesDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CourseServices : IDataRepository<Courses>
    {
        private readonly DbcontextClass _dbcontextClass;
        public CourseServices(DbcontextClass dbcontextClass)
        {
            _dbcontextClass = dbcontextClass;
        }

        public void Add(Courses cources)
        {
            //_dbcontextClass.Coursess.Add(cources);
            //_dbcontextClass.SaveChanges();
            var entity = new Courses
            {
                CourseId = cources.CourseId,
                CourseName = cources.CourseName,
                //Enrollments = cources.Enrollments,
            };
            _dbcontextClass.Coursess.Add(entity);
            _dbcontextClass.SaveChanges();
        }

        public void Delete(Courses entity)
        {
            _dbcontextClass.Coursess.Remove(entity);
            _dbcontextClass.SaveChanges();
        }

        public Courses Get(int id)
        {
            var record = _dbcontextClass.Coursess.Include("Enrollments").FirstOrDefault(x => x.CourseId == id);
            return record;
        }

        public IEnumerable<Courses> GetAll()
        {
            return _dbcontextClass.Coursess.ToList();
        }

        public void Update(Courses dbentity, Courses entity)
        {
            dbentity.CourseName=entity.CourseName;
            _dbcontextClass.SaveChanges();
        }
    }
}
