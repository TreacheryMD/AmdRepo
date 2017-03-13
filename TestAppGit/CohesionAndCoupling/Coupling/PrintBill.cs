using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Coupling
{
    class PrintBill
    {
        public void Print(Employee emp)
        {
            emp.Salary = 100000;
        }
    }
}

