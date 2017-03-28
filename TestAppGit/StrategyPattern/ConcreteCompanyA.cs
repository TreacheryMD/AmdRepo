using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ConcreteCompanyA : Company
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteCompanyA.SomeOperationOne()");
        }
        public override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteCompanyA.SomeOperationTwo()");
        }
    }
}
