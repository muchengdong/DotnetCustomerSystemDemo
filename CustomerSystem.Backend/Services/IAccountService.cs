using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerSystem.Backend.Models;

namespace CustomerSystem.Backend.Services
{
    public interface IAccountService
    {

        string Login();
        
        void SaveUserInfo(UserInfo userInfo);
        
        List<UserInfo> ListUserInfos();

    }
}
