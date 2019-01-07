using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        // TODO: Create GetAccountInfo method with the following specs:
        // Parameters:
        //   - accountNumber (string)
        //   - balance (double) ***
        //   - lastDeposit (DateTime) ***
        // Return type:
        //   - bool

        public bool GetAccountInfo(string accountNumber, out double balance, out DateTime lastDeposit)
        {
            balance = 24127.84;
            lastDeposit = new DateTime(2014, 11, 22, 14, 35, 20);

            bool isActive = true;
            return isActive;
        }

        //Note: Parameters with *** should be defined as out parameters
    }
}