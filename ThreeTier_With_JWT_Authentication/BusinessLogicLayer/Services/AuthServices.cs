using BusinessLogicLayer.Repository;
using DataAccessLayer.DbContextFolder;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class AuthServices : IAuthDataRepository<LoginModel>
    {
        public readonly ApiDbContext? _apiDbContext;
        public AuthServices(ApiDbContext? apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }

        public LoginModel Checkauth(string username, string password)
        {
            var obj=_apiDbContext?.loginModels.FirstOrDefault(x=>x.UserName== username && x.Password == password);
            return obj;
        }
    }
}
