using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOTNET_RPG.Data
{
    public interface IAuthRepository
    {

        public Task<ServiceResponse<int>> Register(User user, string password);

        public Task<ServiceResponse<string>> Login(string username, string password);

        public Task<bool> UserExists(string username);
        
    }
}