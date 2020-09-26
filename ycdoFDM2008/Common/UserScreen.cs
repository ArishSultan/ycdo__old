using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public  class UserScreen
    {
        public UserScreen() { }

        public int ScreenId { get; set; }
        public string ScreenName { get; set; }
        public override string ToString()
        {
            return ScreenName;
        }
    }
}
