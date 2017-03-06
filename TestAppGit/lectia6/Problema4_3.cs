using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia6
{
    class Problema4_3 : Problem
    {
        //	Display only words beginning with uppercase character. 
        string _str;

        public Problema4_3(string str)
        {
            _str = str;
        }

        public void Solve()
        {
            string[] allWords = _str.Split(' ');

            Console.WriteLine("*****Problema4.3*****");

            for (int i = 0; i < allWords.Length; i++)
            {
                if (char.IsUpper(allWords[i].ToCharArray()[0]))
                {
                    Console.Write($"{allWords[i]} ");
                }
            }
            Console.WriteLine("\n*********************");
            Console.ReadLine();
        }

    }
}
