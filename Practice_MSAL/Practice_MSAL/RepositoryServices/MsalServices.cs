using Practice_MSAL.DbFolder;
using Practice_MSAL.Model;
using Practice_MSAL.Repository;

namespace Practice_MSAL.RepositoryServices
{
    public class MsalServices : IDataRepository<Msal_Class>
    {
        private readonly DbClass _dbClass;
        public MsalServices(DbClass dbClass)
        {
            _dbClass= dbClass;
        }       

        public void Add(Msal_Class entity)
        {
            _dbClass.MsalClasses.Add(entity);
            _dbClass.SaveChanges();
        }

        public void Delete(Msal_Class entity)
        {
            _dbClass.MsalClasses.Remove(entity);
            _dbClass.SaveChanges();
        }

        public Msal_Class Get(int id)
        {
           var record= _dbClass.MsalClasses.Find(id);
            return record;
        }

        public IEnumerable<Msal_Class> GetAll()
        {
            return _dbClass.MsalClasses.ToList();
        }

        public void Update(Msal_Class dbentity, Msal_Class entity)
        {
            dbentity.UserName = entity.UserName;
            dbentity.MobileNumber = entity.MobileNumber;
            dbentity.DOB = entity.DOB;
            _dbClass.SaveChanges();
        }
    }
}
