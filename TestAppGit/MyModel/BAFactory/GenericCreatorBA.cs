using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModel.Accounts;

namespace MyModel.BAFactory
{
    public class GenericCreatorBa : CreatorBA
    {
        public override BankAccount CreateBankAccount(string bankAccountType,string line)
        {
            var type = Type.GetType($"MyModel.Accounts.{bankAccountType}");
            if(type==null) throw new Exception("is null...");
            var item = Activator.CreateInstance(type, line);
            return (BankAccount)item;
        }
    }
}
