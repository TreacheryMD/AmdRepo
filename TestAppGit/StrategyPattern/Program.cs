using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HiringStrategyContext hireEmployee = new HiringStrategyContext(new SoftwareEngineer());

            Console.WriteLine("***Strategy for Software Engineer");
            hireEmployee.GetContractDetails();

            hireEmployee = new HiringStrategyContext(new SeniorSoftwareEngineer());

            Console.WriteLine("\n***Strategy for Senior Software Engineer");
            hireEmployee.GetContractDetails();


            hireEmployee = new HiringStrategyContext(new TeamLead());

            Console.WriteLine("\n***Strategy for TeamLead");
            hireEmployee.GetContractDetails();

            //
            //Console.WriteLine("*****************");

            Company aA = new ConcreteCompanyA();
            aA.TemplateMethod(new HiringStrategyContext(new SoftwareEngineer()));



            Console.ReadLine();


            
        }
    }
}
