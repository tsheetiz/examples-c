using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: use different constructors for accounts.
            BankAccount account1 = new BankAccount();

            BankAccount account2 = new BankAccount("College Fund");

            BankAccount account3 = new BankAccount("Checking", new DateTime(2014, 7, 10, 15, 0, 0), 50000);


            Console.WriteLine(account1.GetAccountInfo());

            Console.WriteLine(account2.GetAccountInfo());

            Console.WriteLine(account3.GetAccountInfo());
        }
    }
}