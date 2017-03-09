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
            var a = new AngleT(0, 0, -10);
            var b = new AngleT(359, 59, 50);

            //Console.WriteLine(AngleT.MakeFromDouble(30.2638888888889));
            //Console.WriteLine(AngleT.MakeFromDouble(4.4625));

            //Console.WriteLine(AngleT.ConvertDegreeAngleToDouble(a));
            //Console.WriteLine(AngleT.ConvertDegreeAngleToDouble(b));
            Console.WriteLine(a + b);

            Console.ReadLine();

        }
    }
}
