using BusinessLogicLayer.Repositories;
using DataAccessLayer.DbContextFolder;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class EnrollmentServices : IEnrollmentRepository
    {      
        private readonly DbContextClass? _dbContextClass;
        public EnrollmentServices(DbContextClass? dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<Enrollments> Add(Enrollments Entity)
        {
            //_dbContextClass.Enrollments2.Add(Entity);
            if (_dbContextClass.Courses2.Any(x => x.CourseID == Entity.E_CourseID) && _dbContextClass.Students2.Any(x => x.StudentID == Entity.E_StudentID))
            {
                var enrollment = new Enrollments
                {
                    EnrollmentID = Entity.EnrollmentID,
                    E_CourseID = Entity.E_CourseID,
                    E_StudentID = Entity.E_StudentID,
                };
                _dbContextClass.Enrollments2.Add(enrollment);
                await _dbContextClass.SaveChangesAsync();
                // return _dbContextClass.Enrollments2.OrderByDescending(x => x.EnrollmentID).FirstOrDefault();
                return enrollment;
            }
            else
            {
                return null;
            }
            //int EnrollID = _dbContextClass.Enrollments2.OrderByDescending(x => x.EnrollmentID).FirstOrDefault().EnrollmentID;
        }

        public async Task Delete(Enrollments Entity)
        {
         _dbContextClass.Enrollments2.Remove(Entity);
            await _dbContextClass.SaveChangesAsync();
        }

        public async Task<IEnumerable<Enrollments>> GetAll()
        {
          //return await  _dbContextClass.Enrollments2.ToListAsync();
          return await _dbContextClass.Enrollments2.Include(x=>x.Student).Include(x=>x.Course).ToListAsync();
        }

        public async Task<Enrollments> GetById(int id)
        {
            var record = await _dbContextClass.Enrollments2.FindAsync(id);
            return  record;
        }

        public async Task Update(Enrollments dbEntity, Enrollments Entity)
        {
            dbEntity.E_CourseID = Entity.E_CourseID;
            dbEntity.E_StudentID= Entity.E_StudentID;
            await _dbContextClass.SaveChangesAsync();
        }
    }
}
