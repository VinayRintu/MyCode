using Data_Access_Layer.Models;
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
        Task<Course> Get(int id);
        Task<Course> Add(Course entity);
        Task<Course> Update(Course dbentity, Course entity);
        Task Delete(Course Entity);
    }
}
