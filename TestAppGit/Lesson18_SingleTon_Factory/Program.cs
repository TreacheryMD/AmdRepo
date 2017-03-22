using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson18_SingleTon_Factory.Factory_Method_Pattern;
using Lesson18_SingleTon_Factory.SingleTon;

namespace Lesson18_SingleTon_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Confirm => same instance
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance");
            }

            // load balance 10 requests for a server
            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 10; i++)
            {
                string serverName = balancer.NextServer.Name;
                Console.WriteLine($"Dispatch request to: {serverName}");
            }

            // Wait for user
            Console.ReadKey();


            VehicleFactory factory = new ConcreteVehicleFactory();
            IFactory scooter = factory.GetVehicle("Scooter");
            scooter.Drive(40);

            IFactory bike = factory.GetVehicle("Bike");
            bike.Drive(80);

            Console.ReadKey();

        }
    }
}
