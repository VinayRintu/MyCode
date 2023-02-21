using Data_Access_Layer.Models;
using DataAccessLayer.DbConnectionFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> Get(int id);
        Task<Student> Add(Student entity);
        Task Delete(Student entity);
        Task Update(Student dbentity, Student entity);
      
    }
}
