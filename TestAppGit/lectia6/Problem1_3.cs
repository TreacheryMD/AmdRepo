using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia6
{
    class Problem1_3 : Problem
    {
        //Delete from array all repeating elements except of their first occurrence. 
        public static int[] Array { get; set; }
        public Problem1_3(int[] array)
        {
            Array = array;
        }
        public void Solve()
        {
            List<int?> result = new List<int?>();
            
            for (int i = 0; i < Array.Length; i++)
            {
                if (!result.Contains(Array[i]))
                {
                    result.Add(Array[i]);
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
