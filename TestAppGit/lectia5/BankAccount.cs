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
            Console.WriteLine($"Account Owner: {_owner}/n AccountNumber:{_accountNumber}");
        }
        public virtual string Owner
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

        public virtual string AccountNumber
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

        public virtual decimal Balance
        {
            get { }
        }

    }
}
