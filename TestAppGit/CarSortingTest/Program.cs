using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSortingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car("Ford", 2010, 200);
            Car bmw = new Car();
            Car mercedes = new Car("Mercedes", 2016, 122);
            Car reno = new Car("Reno", 2015, 133);
            Car tayota = new Car("Tayota", 2010, 15);

            List<Car> cars = new List<Car> { ford, bmw, mercedes, reno, tayota };

            Console.WriteLine("Unsorted:");
            Car.ShowFromEnum(cars);

            Console.WriteLine("Ascending:");
            cars.Sort(new SortCarAsc());
            Car.ShowFromEnum(cars);

            Console.WriteLine("Descending:");
            cars.Sort(new SortCarDesc());
            Car.ShowFromEnum(cars);

            Console.ReadLine();
        }
    }
}
