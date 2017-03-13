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

        Stack<char> _myStack = new Stack<char>();

        public Problema5_3(string str)
        {
            _str = (str.Replace(" ", "").Replace(".", "").ToLower());
            foreach (var ch in _str.ToCharArray())
            {
                _myStack.Push(ch);
            }
        }
        public void Solve()
        {
            string temp = string.Empty;
            Console.WriteLine("*****Problema5.3*****");

            while (_myStack.Any()) temp += _myStack.Pop();
            if (_str == temp) Console.WriteLine("Is Polindrom");
            else Console.WriteLine("Is not Polindrom");

            Console.WriteLine("\n*********************");
            Console.ReadLine();
        }
    }
}


