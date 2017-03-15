using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosureExplained
{
    class Program
    {
        static void Main(string[] args)
        {
            var inc = GetFunc();
            Console.WriteLine(inc(5));
            Console.WriteLine(inc(6));
            Console.ReadLine();

            var actions = new List<Action>();
            for (int i = 0; i < 3; i++)
                actions.Add(() => Console.WriteLine(i));
            foreach (var action in actions)
                action();
            Console.ReadLine();

        
            var actions2 = new List<Action>();
            foreach (var i in Enumerable.Range(0, 3))
                actions2.Add(() => Console.WriteLine(i));
            foreach (var action in actions2)
                action();

            Console.ReadLine();

        }

        public static Func<int, int> GetFunc()
        {
            var myVar = 1;
            Func<int, int> inc = delegate (int var1)
            {
                myVar = myVar + 1;
                return var1 + myVar;
            };
            return inc;
        }
    }
    


}
