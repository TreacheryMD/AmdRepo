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
            var a = new Angle(3, 36, 53);
            var b = new Angle(4, 27, 45);

            //Console.WriteLine(Angle.MakeFromDouble(30.2638888888889));
            //Console.WriteLine(Angle.MakeFromDouble(4.4625));

            //Console.WriteLine(Angle.ConvertDegreeAngleToDouble(a));
            //Console.WriteLine(Angle.ConvertDegreeAngleToDouble(b));

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

            Console.ReadLine();
        }
    }
}
