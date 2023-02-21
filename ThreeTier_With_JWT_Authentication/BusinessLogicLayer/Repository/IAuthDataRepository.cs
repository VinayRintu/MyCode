using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repository
{
    public interface IAuthDataRepository<TEntity>
    {
        public LoginModel Checkauth(string username, string password);
    }
}
