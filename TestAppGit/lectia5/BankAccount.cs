using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    abstract class BankAccount
    {
        string _owner;
        string _accountNumber;
        decimal _balance;
        public virtual void ShowAccountInfo()
        {
            Console.WriteLine($"\nAccount Owner: {_owner} \nAccountNumber:{_accountNumber}\nBalance:{_balance} \n****************************\n");
        }
        protected BankAccount(string owner, decimal balance, string accountNumber)
        {
            this.AccountNumber = accountNumber;
            this.Balance = balance;
            this.Owner = owner;
        }

        public string Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }

        public  string AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }

        public  decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

    }
}
