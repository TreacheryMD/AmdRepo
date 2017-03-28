using NUnitTesting.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTesting.Decorator
{
    public class AccountDecorator : BankAccount
    {
        protected BankAccount _bankAccount;
        public AccountDecorator(BankAccount currentAccount)
        {
            _bankAccount = currentAccount;
        }

        public override void Freeze()
        {
            if (_bankAccount != null)
            {
                _bankAccount.Freeze();
            }    
        }

        //protected override void Freeze()
        //{
        //    if (this == null) throw new Exception("Invalid operration");
        //    base.Freeze();
        //}
    }
}
