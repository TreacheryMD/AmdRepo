using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling.Cohesion
{
    class Coincidental
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static void WriteSomething(string message)
        {
            Console.WriteLine(message);
        }

        public static void SaveData(string connectionString,string parammeters)
        {
            //save to DB;
        }
    }
}
