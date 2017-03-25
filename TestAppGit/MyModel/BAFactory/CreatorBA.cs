using MyModel.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyModel.BAFactory
{
    public abstract class CreatorBA
    {
        public abstract BankAccount CreateBankAccount(string bankAccountType,string line);
    }
}
