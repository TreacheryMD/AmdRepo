using CohesionAndCoupling.Coupling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintBill contentCoupling = new PrintBill();
            contentCoupling.Print(new Employee { Salary=1000,Experience = 4,Name="Alex"}); // this method have free acces to sallary 
            

        }
    }
}
