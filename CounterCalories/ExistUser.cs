using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ExistUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public ExistUser(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public ExistUser()
        {
            UserName = "";
            Password = "";
        }
    }
}
