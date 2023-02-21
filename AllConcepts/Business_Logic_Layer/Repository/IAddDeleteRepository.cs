using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Repository
{
    public interface IAddDeleteRepository<TEntity>
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
    }
}
