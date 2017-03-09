using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectiea7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Angle(10, 1, 1);
            var b = new Angle(2, 50, 2);

            //Console.WriteLine(AngleT.MakeFromDouble(30.2638888888889));
            //Console.WriteLine(AngleT.MakeFromDouble(4.4625));

            //Console.WriteLine(AngleT.ConvertDegreeAngleToDouble(a));
            //Console.WriteLine(AngleT.ConvertDegreeAngleToDouble(b));

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"a+b = {a + b}");
            Console.WriteLine($"a-b = {a - b}");
            Console.WriteLine($"a/b = {a / b}");
            Console.WriteLine($"a*b = {a * b}");
            Console.WriteLine($"a>b = {a > b}");
            Console.WriteLine($"a<b = {a < b}");
            Console.WriteLine($"a<=b = {a <= b}");
            Console.WriteLine($"a>=b = {a >= b}");
            Console.WriteLine("-----------------");

            Car ford = new Car("Ford", 2010, 200);
            Car bmw = new Car();
            Car mercedes = new Car("Mercedes", 2016, 122);
            Car reno = new Car("Reno", 2015, 133);
            Car tayota = new Car("Tayota", 2010, 15);

            Car[] cars = new Car[] { ford, bmw, mercedes, reno, tayota };
 
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}  {car.Speed}");
            }
            Console.WriteLine("-----------------");

            Car.Sort(cars);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}  {car.Speed}");
            }
            

            Console.ReadLine();

        }
    }
}
