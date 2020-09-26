namespace BLL
{
    using DAL;
    using Common;
    using System;
    using System.Collections.Generic;

    public class UserBLL
    {
        public bool DeleteUser(User user)
        {
            return new LoginDB().DeleteUser(user);
        }

        public bool EditUser(User user)
        {
            return new LoginDB().EditUser(user);
        }

        public List<User> GetUsers()
        {
            return new LoginDB().GetUsers();
        }

        public string ReturnConString()
        {
            return new LoginDB().ReturnConString();
        }

        public bool SaveUser(User user)
        {
            return new LoginDB().SaveUser(user);
        }

        public bool VerifyUser(User user)
        {
            return new LoginDB().VerifyUser(user);
        }

        public bool SaveUserRights(List<UserRight> userRights)
        {
            return new UserRightDAL().SaveUserRights(userRights);
        }
        public List<UserRight> GetUserRights(User user)
        {
            return new UserRightDAL().GetUserRights(user);
        }

    }
}

