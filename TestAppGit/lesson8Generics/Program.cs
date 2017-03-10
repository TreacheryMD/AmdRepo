using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomGenericArray<object> testing = new CustomGenericArray<object>(8); //max 20

            testing[0] = "tttt";
            testing[1] = 7;
            testing[2] = "xxx";
            testing[3] = "x";
            testing[4] = "x";
            testing[5] = 1;
            testing[6] = "x";
            testing[7] = 1;

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"{testing[i]}   ");
            }
            Console.WriteLine();

            testing.SwapByValue(1, "tttt");
           

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"{testing[i]} ");
            }

        }
    }
}
