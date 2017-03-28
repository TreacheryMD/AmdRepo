using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitTesting.Accounts;

namespace NUnitTesting.BAFactory
{
    public class GenericCreatorBa : CreatorBA
    {
        public override BankAccount CreateBankAccount(string bankAccountType,string line)
        {
            var type = Type.GetType($"MyModel.Accounts.{bankAccountType}");
            var item = Activator.CreateInstance(type, line);
            return (BankAccount)item;
        }
    }
}
