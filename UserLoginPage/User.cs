using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginPage
{
    class User
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string email{ get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        public string Logged(string name, string surname)
        {
            return ($"Welcome Back {name} {surname}");
        }
        public string NewLog(string name,string surname,string email,string username,string password)
        {
            return $"Hello! {name} {surname}, your {username} named account has opened and confirmation email sended to {email}";
        }
    }
}
