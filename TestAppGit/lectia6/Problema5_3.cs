using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia6
{
    class Problema5_3 : Problem
    {
        //Write a program that uses a stack to determine whether a string is a palindrome (i.e., the string is spelled identically backward and forward). The program should ignore capitalization, spaces and punctuation.
        string _str;
        public Problema5_3(string str)
        {
            _str = str.Replace(" ","").Replace(".","").ToLower();
        }

        public void Solve()
        {
            Stack<char> fStack = new Stack<char>();
            Stack<char> sStack = new Stack<char>();

            foreach (var ch in _str.ToCharArray())
            {
                fStack.Push(ch);
            }

            for (int i = 0; i < _str.Length/2; i++)
            {
                sStack.Push(fStack.Pop());
            }

            var nothing = fStack.Pop();

            Console.WriteLine("*****Problema5.3*****");

            int k = 0;
            while (fStack.ElementAt(k)==sStack.ElementAt(k))
            {
                k++;
                if ((k > _str.Length / 2-1))
                {
                    Console.WriteLine("Is Polindrom");
                    break;
                    
                }
            }

            Console.WriteLine("\n*********************");
            Console.ReadLine();

        }
    }
}
