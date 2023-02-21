using WebApi_With_Ef_CodeFirst.Database_Connection;
using WebApi_With_Ef_CodeFirst.Models;
using WebApi_With_Ef_CodeFirst.Repository;

namespace WebApi_With_Ef_CodeFirst.Services
{
    public class EmployeeServices : IDataRepository<Employee>
    {
        private readonly EmployeeContext _employeeContext;
        public EmployeeServices(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public void Add(Employee entity)
        {
            _employeeContext.Employees.Add(entity);
            _employeeContext.SaveChanges();
        }

        public void Delete(Employee entity)
        {
           _employeeContext.Employees.Remove(entity);
            _employeeContext.SaveChanges();
        }

        public Employee Get(int id)
        {
            var record = _employeeContext.Employees.Find(id);
            return record;
        }

        public IEnumerable<Employee> GetAll()
        {
           return   _employeeContext.Employees.ToList();
        }

        public void Update(Employee dbentity, Employee entity)
        {
            dbentity.EmployeeName = entity.EmployeeName;
            dbentity.DateOfBirth = entity.DateOfBirth;
            dbentity.PhoneNumber= entity.PhoneNumber;
            dbentity.Email = entity.Email;

            _employeeContext.SaveChanges();
        }
    }
}
