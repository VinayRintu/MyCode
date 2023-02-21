using Business_Logic_Layer.Repository;
using Data_Access_Layer.DbContextFolder;
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services
{
    public class StudentServices : IGetRepository<Student>,IUpdateRepository<Student>, IAddDeleteRepository<Student>
    {
        private readonly DbContextClass? _dbContextClass;
        public StudentServices(DbContextClass? dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public void Add(Student entity)
        {
            _dbContextClass.Students.Add(entity);
            _dbContextClass.SaveChanges();
        }

        public void Delete(Student entity)
        {
            _dbContextClass.Students.Remove(entity);
            _dbContextClass.SaveChanges();
        }

        public Student Get(int id)
        {
            var record = _dbContextClass.Students.Find(id);
            return record;
        }

        public IEnumerable<Student> GetAll()
        {
            return _dbContextClass.Students.ToList();
        }

        public void Update(Student dbentity, Student entity)
        {
            dbentity.StudentName = entity.StudentName;
            _dbContextClass.SaveChanges();
        }
    }
}
