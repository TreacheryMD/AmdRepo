using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_SingleTon_Factory.Factory_Method_Pattern
{
    public class Bike : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine($"Drive the Bike:{km} km");
        }
    }
}
