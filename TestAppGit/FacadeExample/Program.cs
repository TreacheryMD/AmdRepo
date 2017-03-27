using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeExample
{
    class Program
    {
        // CarModel, CarEngine, CarBody, CarAccessories - Are subsystems.
        // CarFacade- Facade class.
        static void Main(string[] args)
        {
            CarFacade facade = new CarFacade();
       
            facade.CreateCompleteCar();

            Console.ReadKey();
        }

        //A simple interface is required to access to a complex system.
        //The abstractions and implementations of a subsystem are tightly coupled.
        //Need an entry point to each level of layered software.
        //The facade design pattern is particularly used when a system is very complex or difficult to understand because system has a large number of interdependent classes or its source code is unavailable
    }
}
