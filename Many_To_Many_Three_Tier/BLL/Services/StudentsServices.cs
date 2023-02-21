using BLL.Repository;
using DAL.Models;
using DAL.TablesDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentsServices : IDataRepository<Students>
    {
        private readonly DbcontextClass _dbcontextClass;
        public StudentsServices(DbcontextClass dbcontext)
        {
            _dbcontextClass = dbcontext;
        }
        public void Add(Students students)
        {
            //_dbcontextClass.Studentss.Add(entity);
            //_dbcontextClass.SaveChanges();
            var entity = new Students
            {
                StudentId = students.StudentId,
                StudentName = students.StudentName,
                Standard = students.Standard,
                //Enrollments = students.Enrollments,
            };
            _dbcontextClass.Studentss.Add(entity);
            _dbcontextClass.SaveChanges();
        }

        public void Delete(Students entity)
        {
            _dbcontextClass.Studentss.Remove(entity);
            _dbcontextClass.SaveChanges();
        }

        public Students Get(int id)
        {
            var record = _dbcontextClass.Studentss.Include("Enrollments").FirstOrDefault(x => x.StudentId == id);
            return record;
        }

        public IEnumerable<Students> GetAll()
        {
            return _dbcontextClass.Studentss.ToList();
        }

        public void Update(Students dbentity, Students entity)
        {
            dbentity.StudentName = entity.StudentName;
            dbentity.Standard = entity.Standard;
            _dbcontextClass.SaveChanges();
        }
    }
}
