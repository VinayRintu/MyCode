using BusinessLogicLayer.Repository;
using DataAccessLayer.DbContextFolder;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class EmpServices : IDataRepository<Employee>
    {
        private readonly ApiDbContext? _apiDbContext;
        public EmpServices(ApiDbContext? apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public void Add(Employee entity)
        {
            _apiDbContext.employees.Add(entity);
            _apiDbContext.SaveChanges();
        }

        public Employee Get(int id)
        {
            var record = _apiDbContext.employees.Find(id);
            return record;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _apiDbContext.employees.ToList();
        }
    }
}
