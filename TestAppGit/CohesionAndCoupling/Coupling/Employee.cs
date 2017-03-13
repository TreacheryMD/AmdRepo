using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Coupling
{
    class Employee
    {
        public string Name;
        public int Experience;
        public int Salary;

        public static void PromoteEmployee(Employee empl)
        {
            if (empl.Experience > 4)
            {
                Console.WriteLine($"{empl.Name} has been promoted");
            }
        }
    }
}

