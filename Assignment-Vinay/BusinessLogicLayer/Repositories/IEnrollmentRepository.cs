using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public interface IEnrollmentRepository
    {
        Task<IEnumerable<Enrollments>> GetAll();
        Task<Enrollments> GetById(int id);
        Task Update(Enrollments dbEntity, Enrollments Entity);
        Task Delete(Enrollments Entity);
        Task<Enrollments> Add(Enrollments Entity);
    }
}
