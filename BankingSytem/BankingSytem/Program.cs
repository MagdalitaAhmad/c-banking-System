using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSytem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program prograns = new Program();
            prograns.loggedin();
        }
        public void loggedin()
        {
            classManager accmanager = new classManager();
            bool loggedIn = false; // Introduce a flag to track the login status
            while (true)
            {
                if (!loggedIn) // Display the menu only if not logged in
                {
                    Console.WriteLine("1. Create Account");
                    Console.WriteLine("2. Log In");
                    Console.WriteLine("3. Switch Account");
                    Console.WriteLine("4. Add Another Account");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter your choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            accmanager.CreateAccount();
                            break;
                        case "2":
                            accmanager.Login();
                            loggedIn = true; // Set the flag to true after logging
                            break;
                            
                        case "3":
                            accmanager.SwitchAccount();
                            break;
                        case "4":
                            accmanager.CreateAccount();
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }
    }
}
