using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizATest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            a = new B(3);
            a.Method();
            Console.ReadKey();
        }

    }
    public class A
    {
        static A()
        {
            Console.WriteLine("Static A.");
        }

        public A()
        {
            Console.WriteLine("A.");
        }

        public A(int m)
        {
            Console.WriteLine("Am.");
        }

        public virtual void Method()
        {
            Console.WriteLine("Method A.");
        }
    }

    public class B : A
    {
        static B()
        {
            Console.WriteLine("Static B.");
        }

        public B()
        {
            Console.WriteLine("B.");
        }

        public B(int m) : base(m)
        {
            Console.WriteLine("Bm.");
        }

        public override void Method()
        {
            Console.WriteLine("Method B.");
        }
    }

}
