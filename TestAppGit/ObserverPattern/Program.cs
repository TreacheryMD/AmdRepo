using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Observer firstClient = new Observer("I am first client");
            store.Subscribe(firstClient);
            store.Subscribe(new Observer("I am second client"));
            store.Inventory++;
            store.Unsubscribe(firstClient);
            store.Subscribe(new Observer("I am third client"));
            store.Inventory++;
            Console.ReadLine();
        }
    }
}
