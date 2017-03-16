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
            Car.Colour = "red";
            Sedan car2 = new Sedan(2.45);
            var commonCoupling = car2.SecondCollor; //all sedans will depend on Car collor class


            List<Car> carList = new List<Car>() { new Car(1.45,20), new Car(1.5, 18), new Car(2.00, 22), };

            carList.Sort(new SortCarAsc()); // good control coupling - allow factoring and reuse of functionality
            List<Car> badControlCoupling = Car.ModifyList(carList,2); // Bad control coupling - indicate completely different behavior

            //Stamp coupling occurs when modules share a composite data structure and use only parts of it, possibly different parts (e.g., passing a whole record to a function that only needs one field of it).
            //In this situation, a modification in a field that a module does not need may lead to changing the way the module reads the record.
            //car speed is modified, speed modifiec CO2 is modified
            car.Co2Emission = 1;
            Poluation.SomeCalc(car);
            car.Accelerate(20);
            Poluation.SomeCalc(car);
            //
            Statistic newStatistics = new Statistic();
            newStatistics.SomeStatisticCalculation(car); //data coupling > uses all car fields

            


        }
    }
}
