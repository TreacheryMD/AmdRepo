using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestAppGit.Console
{
     class Program
    {
        private static void Main(string[] args)
        {
            A a;
            B b= new B();
            var test = b as A;

            System.Console.WriteLine(test == null);


        }
    }
    class A
    {
        private readonly int test = 10;

        public void changeNumber(int numb)
        {
           // this.test
        }
    }

    class B : A
    {

    }

    class  C:A
    {
        
    }
}
