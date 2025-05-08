using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerSystem.Backend.Models;
using LinqToDB;

namespace CustomerSystem.Backend.Services.Impl
{
    internal class AccountServiceImpl : IAccountService
    {
        public string Login()
        {
            return "test ok";
        }

        public void SaveUserInfo(UserInfo userInfo)
        {
            using (var db = new DbContext())
            {
                db.Insert(userInfo);
            }
        }

        public List<UserInfo> ListUserInfos()
        {
            using (var db = new DbContext())
            {
                return db.UserInfo.ToList();
            }
        }
    }
}