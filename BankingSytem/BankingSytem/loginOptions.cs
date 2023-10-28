using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSytem
{
    internal class loginOptions
    {
        Program newprogram = new Program();

        public void options()
        {
            Console.WriteLine("1. Deposit Money");
            Console.WriteLine("2. Check Balance");
            Console.WriteLine("3. Widraw");
            Console.WriteLine("4. Back");

            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("You choose 1");
                    break;
                case "2":
                    Console.WriteLine("You choose 2");
                    break;
                case "3":
                    Console.WriteLine("You choose 3");
                    break;
                case "4":
                    Console.WriteLine("You choose 4");
                    newprogram.loggedin();
                    break;
            }

        }
        
    }
}
