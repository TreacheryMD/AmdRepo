using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class TeamLead : ICompanyStrategy
    {
        public string EmployeeStrategies()
        {
            return "Policies for Team Lead";
        }
    }
}
