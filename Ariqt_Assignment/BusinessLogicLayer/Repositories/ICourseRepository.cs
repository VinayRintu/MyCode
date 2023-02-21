using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> GetAll();
        Task<Course> GetById(int id);
        Task Update(Course dbentity, Course entity);
        Task<Course> Add(Course entity);
        Task Delete(Course entity);
    }
}
