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

            Car car = new Car(1.44d);
            car.Colour = "Red";
            Sedan car2 = new Sedan(car,2.45);
            var commonCoupling = car2.SecondCollor; //all sedans will depend on Car collor class



        }
    }
}
