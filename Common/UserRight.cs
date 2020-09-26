using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public class UserRight
    {
        public UserRight()
        {
            this.Screen = new UserScreen();
            this.User = new User();
        }

        public int RightId { get; set; }
        public User User { get; set; }
        public bool CanAccess { get; set; }
        public UserScreen Screen { get; set; }
    }
}
