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
            Problem1_3 problem1_3 = new Problem1_3(new int?[] { 1, 1, 2,0, 2, 4, 4, 1, 1, 2, 2 });
            problem1_3.Solve();

            Problema2_3 problem2_3 = new Problema2_3(new int[5, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 }, { 4, 4, 5, 4 } });
            problem2_3.Solve();

            Problema3_3 problem3_3 = new Problema3_3("aaabbb", 'a', 'b');
            problem3_3.Solve();



        }
    }
}
