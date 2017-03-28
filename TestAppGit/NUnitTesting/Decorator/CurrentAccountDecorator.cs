using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitTesting.Accounts;

namespace NUnitTesting.Decorator
{
    public class CurrentAccountDecorator : AccountDecorator
    {
        public CurrentAccountDecorator(BankAccount currentAccount) : base(currentAccount)
        {

        }

        public override void Freeze()
        {
            base.Freeze();
            Console.WriteLine("Another type of freeze aplied // from decorator");
        }
    }
}
