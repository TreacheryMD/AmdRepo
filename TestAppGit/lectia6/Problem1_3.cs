using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia6
{
    class Problem1_3
    {
        public static int?[] Array { get; set; }
        public Problem1_3(int?[] array)
        {
            Array = array;
        }

        public void Solve()
        {
            List<int?> result = new List<int?>();
            
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j <= Array.Length - 1; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        Array[i] = null;
                        break;
                    }
                }
            }

            foreach (var item in Array)
            {
                if (item != null)
                {
                    result.Add(item);
                }
            }

            Console.WriteLine("*****Problema1.3*****");
            foreach (var item in result.ToArray())
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n*********************");
            Console.ReadLine();
        }
    }
}
