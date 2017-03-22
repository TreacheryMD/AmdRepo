using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Interfaces;

namespace MyModel.Accounts
{
    public class ConcreteBankAccountFactory : BankAccountFactory
    {
        public override IBankAccountFactory GetAccount(string accountType)
        {
            throw new NotImplementedException();
        }
    }
}
