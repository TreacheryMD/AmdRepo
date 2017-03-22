using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_SingleTon_Factory.Factory_Method_Pattern
{
    public class Scooter : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine($"Drive the Scooter: {km} km");
        }
    }
}
