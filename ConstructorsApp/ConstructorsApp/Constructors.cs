using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsApp
{
    public class BankAccount
    {
        private double balance;
        private DateTime lastDeposit;
        private bool isActive;
        private string accountName;

        // TODO: add constructors

        public BankAccount(string accountName, DateTime lastDeposit, double balance = 0)
        {
            this.balance = balance;
            this.lastDeposit = lastDeposit;
            this.accountName = accountName;

            isActive = true;
        }

        public BankAccount(string accountName) : this(accountName, DateTime.Now)
        { 

        }

        public BankAccount() : this("Unkown Account", new DateTime())
        {
            isActive = false;
        }

        public string GetAccountInfo()
        {
            return String.Format("{0}:  Balance: {1}. Last Deposit: {2}, IsActive: {3}",
                accountName,
                balance,
                lastDeposit,
                isActive);
        }
    }
}