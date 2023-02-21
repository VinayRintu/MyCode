using WEbApi_One_to_Many_Relational.Dbcontext;
using WEbApi_One_to_Many_Relational.Models;
using WEbApi_One_to_Many_Relational.Repository;

namespace WEbApi_One_to_Many_Relational.Services
{
    public class StateServices : IDataRepository<State>
    {
        private readonly TablesDbcontext _dbcontext;
        public StateServices(TablesDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Add(State entity)
        {
            _dbcontext.States.Add(entity);
            _dbcontext.SaveChanges();
        }

        public void Delete(State entity)
        {
            _dbcontext.States.Remove(entity);
            _dbcontext.SaveChanges();
        }

        public IEnumerable<State> GetAll()
        {
            return _dbcontext.States.ToList();
        }

        public State Get(int id)
        {
           var record=_dbcontext.States.Find(id);
            return record;
        }

        public void Update(State dbentity, State entity)
        {
            dbentity.StateName = entity.StateName;
            _dbcontext.SaveChanges();
        }
    }
}
