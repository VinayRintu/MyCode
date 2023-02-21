namespace WebApi_With_Ef_CodeFirst.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
       // List<TEntity> FindAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity dbentity, TEntity entity);
        void Delete(TEntity entity);
    }
}
