using Key_Vault.DbConnection;
using Key_Vault.Models;
using Key_Vault.Repository;

namespace Key_Vault.Services
{
    public class CustomerServices : IDataRepository<Customer>
    {
        private readonly CustomerDbContext? _customerDbContext;
        public CustomerServices(CustomerDbContext? customerDbContext)
        {
            _customerDbContext = customerDbContext;
        }

        public void Add(Customer entity)
        {
            _customerDbContext.Customers1.Add(entity);
            _customerDbContext.SaveChanges();
        }

        public void Delete(Customer entity)
        {
            
            _customerDbContext.Customers1.Remove(entity);
            _customerDbContext.SaveChanges();
        }

        public Customer Get(int id)
        {
            var record = _customerDbContext.Customers1.Find(id);
            return record;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerDbContext.Customers1.ToList();
        }

        public void Update(Customer dbentity, Customer entity)
        {
            //dbentity.CustID= entity.CustID;
            dbentity.CustName= entity.CustName;
            dbentity.MobileNumber= entity.MobileNumber;
            dbentity.Email= entity.Email;
            _customerDbContext.SaveChanges();
        }
    }
}
