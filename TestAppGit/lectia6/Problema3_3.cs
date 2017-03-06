using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectia6
{
    class Problema3_3
    {
        string _myStr;
        char _firstChar;
        char _secondChar;

        public Problema3_3(string str,char firstChar,char secondChar)
        {
            _myStr = str;
            _firstChar = firstChar;
            _secondChar = secondChar;
        }

        public void Solve()
        {
            int fCount = 0;
            int sCound =0;
            foreach (var item in _myStr.ToCharArray())
            {
                if (item == _firstChar) fCount++;
                if (item == _secondChar) sCound++;
            }

            Console.WriteLine("*****Problema3.3*****");
            string result;

            if (fCount > sCound) result = $"Most often char in your STRING is: {_firstChar}";
            else if (fCount < sCound) result = $"Most often char in your STRING is: {_secondChar}"; 
            else result = $"\"{_firstChar}\" and \"{_secondChar}\" characters ar in same ammount";

            Console.WriteLine(result);

            Console.WriteLine("\n*********************");
            Console.ReadLine();

        }


    }
}
