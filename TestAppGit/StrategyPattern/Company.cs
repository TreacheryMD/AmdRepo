using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    abstract class Company
    {
        private IHiringStrategyContext _hiringStrategyContext;
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        // The "Template method"
        public void TemplateMethod(IHiringStrategyContext hiringStrategyContext)
        {
            _hiringStrategyContext = hiringStrategyContext;
            _hiringStrategyContext.DefineStrategies();

            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}
