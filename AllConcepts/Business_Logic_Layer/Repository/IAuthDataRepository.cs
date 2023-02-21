using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Repository
{
    public interface IAuthDataRepository<TEntity>
    {
        public LoginModel CheckAuth(string username, string password);
    }
}
