using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSytem
{
    internal class accounts
    {
        private string username;
        private string password;
        public accounts(string username, string password) {
            this.username = username;
            this.password = password;
        }

        public string getusername()
        {
            return username;
        }

        public string getpassword()
        {
            return password;
        }
    }
}
