using BLL.Repository;
using DAL.Models;
using DAL.TablesDbContext;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EnrollmentServics : IDataRepository<Enrollments>
    {
        private readonly DbcontextClass _dbcontextClass;
        public EnrollmentServics(DbcontextClass dbcontextClass)
        {
            _dbcontextClass = dbcontextClass;
        }

        public void Add(Enrollments enroll)
        {
            var entity = new Enrollments
            {
                EnrollmentId = enroll.EnrollmentId,
                StudentId = enroll.StudentId,
                CourseId = enroll.CourseId,
            };
            _dbcontextClass.Add(entity);
            _dbcontextClass.SaveChanges();
        }

        public void Delete(Enrollments entity)
        {
            _dbcontextClass.Enrollmentss.Remove(entity);
            _dbcontextClass.SaveChanges();
        }

        public Enrollments Get(int id)
        {
            var record = _dbcontextClass.Enrollmentss.Find(id);
            return record;
        }

        public IEnumerable<Enrollments> GetAll()
        {
            return _dbcontextClass.Enrollmentss.ToList();
        }

        public void Update(Enrollments dbentity, Enrollments entity)
        {
           dbentity.StudentId = entity.StudentId;
            dbentity.CourseId = entity.CourseId;
            _dbcontextClass.SaveChanges();
        }
    }
}
