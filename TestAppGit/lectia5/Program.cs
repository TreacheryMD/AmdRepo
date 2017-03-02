using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia5
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle newVehicle = new Truck();
            newVehicle.horn();
            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public int _numberOfPassagers;
        public virtual void horn() { }
    }

    class Car : Vehicle
    {
        public override void horn()
        {
            Console.Write("car sound horn");
        }
    }
    class Truck : Vehicle
    {
        public override void horn()
        {
            Console.Write("truck sound horn");
        }
    }

}
