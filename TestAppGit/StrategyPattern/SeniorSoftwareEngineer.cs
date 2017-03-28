using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SeniorSoftwareEngineer : ICompanyStrategy
    {
        public string EmployeeStrategies()
        {
            return "Contract for Senior software Engineer";
        }
    }
}
