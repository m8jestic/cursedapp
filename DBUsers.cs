using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursedapp
{
    public class DBUsers
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }

         public DBUsers() { }
        public DBUsers(string login, string password)
        {
           
            this.login = login;
            this.password = password;

        }   
    }
}
