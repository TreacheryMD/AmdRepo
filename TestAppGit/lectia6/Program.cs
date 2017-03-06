using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia6
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1_3 problem13 = new Problem1_3(new int?[] { 1, 1, 2,0, 2, 4, 4, 1, 1, 2, 2 });
            problem13.Solve();
        }
    }
}
