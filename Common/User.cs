namespace Common
{
    using System;

    public class User
    {
        private bool isAdmin;
        private bool isLogin;
        private string userName;
        private int userno;
        private string userPassword;

        public User()
        {
        }
        public User(int UserNo):this()
        {
            this.Userno = UserNo;
        }
        public User(string username, string userpass) : this()
        {
            this.userName = username;
            this.userPassword = userpass;
        }

        public User(string username, string userpass, bool isadmin) : this()
        {
            this.userName = username;
            this.userPassword = userpass;
            this.isAdmin = isadmin;
        }

        public User(int userno, string username, string userpass, bool isadmin) : this()
        {
            this.userno = userno;
            this.userName = username;
            this.userPassword = userpass;
            this.isAdmin = isadmin;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            User user = obj as User;
            if (user == null)
            {
                return false;
            }
            return (this.userName == user.userName);
        }

        public override string ToString()
        {
            return this.userName;
        }

        public bool IsAdmin
        {
            get
            {
                return this.isAdmin;
            }
            set
            {
                this.isAdmin = value;
            }
        }

        public bool IsLogin
        {
            get
            {
                return this.isLogin;
            }
            set
            {
                this.isLogin = value;
            }
        }

        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }

        public int Userno
        {
            get
            {
                return this.userno;
            }
            set
            {
                this.userno = value;
            }
        }

        public string UserPassword
        {
            get
            {
                return this.userPassword;
            }
            set
            {
                this.userPassword = value;
            }
        }
    }
}

