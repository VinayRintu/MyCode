using WEbApi_One_to_Many_Relational.Dbcontext;
using WEbApi_One_to_Many_Relational.Models;
using WEbApi_One_to_Many_Relational.Repository;

namespace WEbApi_One_to_Many_Relational.Services
{
    public class CityServices : IDataRepository<City>
    {
        private readonly TablesDbcontext _dbcontext;
        public CityServices(TablesDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Add(City city)
        {
            //_dbcontext.Cities.Add(entity);
            var entity = new City
            {
                CityId=city.CityId,
                CityName=city.CityName,
                StateId=city.StateId,
            };
            _dbcontext.Add(entity);
            _dbcontext.SaveChanges();
        }

        public void Delete(City entity)
        {
           _dbcontext.Cities.Remove(entity);
            _dbcontext.SaveChanges();
        }       

        public IEnumerable<City> GetAll()
        {
           return _dbcontext.Cities.ToList();
        }

        public City Get(int id)
        {
            var record = _dbcontext.Cities.Find(id);
            return record;
        }

        public void Update(City dbentity, City entity)
        {
           dbentity.CityName = entity.CityName;
            dbentity.StateId= entity.StateId;
            _dbcontext.SaveChanges();
        }
    }
}
