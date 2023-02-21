using BusinessLogicLayer.Repositories;
using Data_Access_Layer.Models;
using DataAccessLayer.DbConnectionFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ServicesForRepository
{
    public class StudentServices : IStudentRepository
    {
        private readonly DbContextClass? _dbContextClass;
        public StudentServices(DbContextClass? dbConnectionClass)
        {
            _dbContextClass = dbConnectionClass;
        }

        public async Task<Student> Add(Student student)
        {
            try
            {
                var entity = new Student
                {
                    StudentName = student.StudentName,
                    MobileNumber = student.MobileNumber,
                };
                _dbContextClass.Add(entity);
                await _dbContextClass.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task Delete(Student entity)
        {
            try
            {
                _dbContextClass.Remove(entity);
                await _dbContextClass.SaveChangesAsync();
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task<Student> Get(int id)
        {
            try
            {
                var record = await _dbContextClass.Students1.FindAsync(id);
                return record;
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            try
            {
                return await _dbContextClass.Students1.ToListAsync();
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task Update(Student dbentity, Student entity)
        {
            try
            {
                dbentity.StudentName = entity.StudentName;
                dbentity.MobileNumber = entity.MobileNumber;
                await _dbContextClass.SaveChangesAsync();
            }
            catch(Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
