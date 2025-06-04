using System.Collections.Generic;
using CustomerSystem.Backend.Models;

namespace CustomerSystem.Backend.Services {
    public interface IAccountService {
        string Login();

        void SaveUserInfo(UserInfo userInfo);

        List<UserInfo> ListUserInfos();
    }
}