namespace WEbApi_One_to_Many_Relational.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity dbentity, TEntity entity);
        void Delete(TEntity entity);
    }
}
