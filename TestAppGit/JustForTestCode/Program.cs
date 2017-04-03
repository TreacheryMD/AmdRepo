using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustForTestCode
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Func<int>> actions = new List<Func<int>>();

            int variable = 0;
            while (variable < 5)
            {
                actions.Add(() => variable * 2);
                ++variable;
            }

            foreach (var act in actions)
            {
                Console.WriteLine(act.Invoke());
            }
        }
    }
}
