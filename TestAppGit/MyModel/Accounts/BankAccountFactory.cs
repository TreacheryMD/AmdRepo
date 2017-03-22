using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Interfaces;

namespace MyModel.Accounts
{
    public abstract class BankAccountFactory
    {
        public abstract IBankAccountFactory GetAccount(string accountType);
    }
}
