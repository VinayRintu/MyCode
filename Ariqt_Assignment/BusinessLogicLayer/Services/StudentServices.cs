using BusinessLogicLayer.Repositories;
using DataAccessLayer.DbContextFolder;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class StudentServices : IStudentRepository
    {
        private readonly DbContextClass? _dbContextClass;
        public StudentServices(DbContextClass? dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task Add(Student entity)
        {
            var student = new Student
            {
                StudentName = entity.StudentName,
                MobileNumber = entity.MobileNumber,
            };
            _dbContextClass.Add(student);
            await _dbContextClass.SaveChangesAsync();
        }

        public async Task Delete(Student entity)
        {
            _dbContextClass.Remove(entity);
            await _dbContextClass.SaveChangesAsync();
        }
      
        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _dbContextClass.Students2.ToListAsync();
        }

        public async Task<Student> GetById(int id)
        {
            var record = await _dbContextClass.Students2.FindAsync(id);
            return  record;
        }

        public async Task Update(Student dbentity, Student entity)
        {
            dbentity.StudentName = entity.StudentName;
            dbentity.MobileNumber = entity.MobileNumber;
            await _dbContextClass.SaveChangesAsync();
        }
    }
}
