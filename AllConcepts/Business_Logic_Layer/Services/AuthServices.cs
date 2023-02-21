using Business_Logic_Layer.Repository;
using Data_Access_Layer.DbContextFolder;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services
{
    public class AuthServices : IAuthDataRepository<LoginModel>
    {
        public readonly DbContextClass? _dbContext;
        public AuthServices(DbContextClass? dbContext)
        {
            _dbContext = dbContext;
        }

        public LoginModel CheckAuth(string username, string password)
        {
           var obj=_dbContext?.AllLoginModels.FirstOrDefault(x=>x.UserName==username && x.Password==password);
            return obj;
        }
    }
}
