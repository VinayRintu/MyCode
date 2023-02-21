using BusinessLogicLayer.Repositories;
using DataAccessLayer.DbConnectionFolder;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;


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
            try
            {
                //_dbContextClass.Enrollments2.Add(Entity);
                if (_dbContextClass.Courses1.Any(x => x.CourseID == Entity.CourseId) && _dbContextClass.Students1.Any(x => x.StudentID == Entity.StudentId))
                {
                    if (_dbContextClass.Enrollments1.Any(x => x.CourseId == Entity.CourseId && x.StudentId == Entity.StudentId))
                    {
                        var duplicateData = new Enrollments { EnrollmentID = 1 };
                        return duplicateData;
                    }
                    var enrollment = new Enrollments
                    {
                        EnrollmentID = Entity.EnrollmentID,
                        CourseId = Entity.CourseId,
                        StudentId = Entity.StudentId,
                    };
                    _dbContextClass.Enrollments1.Add(enrollment);
                    await _dbContextClass.SaveChangesAsync();
                    // return _dbContextClass.Enrollments2.OrderByDescending(x => x.EnrollmentID).FirstOrDefault();
                    return enrollment;
                }
                else
                {
                    return null;
                }
            }
           catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task Delete(Enrollments Entity)
        {
            try
            {
                _dbContextClass.Enrollments1.Remove(Entity);
                await _dbContextClass.SaveChangesAsync();
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task<IEnumerable<Enrollments>> GetAll()
        {
            try
            {
                return await _dbContextClass.Enrollments1.Include(x => x.Student).Include(x => x.Course).ToListAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Enrollments> GetById(int id)
        {
            try
            {
                var record = await _dbContextClass.Enrollments1.Include(x => x.Student).Include(x => x.Course).FirstOrDefaultAsync(c => c.EnrollmentID == id);
                return record;
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task Update(Enrollments dbEntity, Enrollments Entity)
        {
            try
            {
                dbEntity.CourseId = Entity.CourseId;
                dbEntity.StudentId = Entity.StudentId;
                await _dbContextClass.SaveChangesAsync();
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
