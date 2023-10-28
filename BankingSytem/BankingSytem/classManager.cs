using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankingSytem
{
    internal class classManager
    {
        private List<accounts> accounts = new List<accounts>();
        loginOptions loginOptions = new loginOptions();
        Program program = new Program();
        public void CreateAccount()
        {
            Console.Write("Enter a username for your new account: ");
            string username = Console.ReadLine();
            Console.Write("Enter a password for your new account: ");
            string password = Console.ReadLine();
            accounts account = new accounts(username, password);
            accounts.Add(account);
            Console.Clear();
            Console.WriteLine("Account created successfully!\n");
        }

        public void Login()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            foreach (accounts account in accounts)
            {
                if (account.getusername().Equals(username) && account.getpassword().Equals(password))
                {
                    Console.Clear();
                    Console.WriteLine("Login successful!");
                    loginOptions.options();
                    return;
                }
                Console.WriteLine("Invalid username or password. Please try again.");
                program.loggedin();
            }

            

        }

        public void clearconsole()
        {
            Console.WriteLine("\033[H\033[2J");
            Console.Clear();
        }

        public void SwitchAccount()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            foreach (accounts account in accounts)
            {
                if (account.getusername().Equals(username))
                {
                    Console.WriteLine("Switched to account: " + account.getusername());
                    return;
                }
            }

            Console.WriteLine("Account not found.");

        
        }
    }
}
