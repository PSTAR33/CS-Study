using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._9
{
    internal class _9_09
    {
        static void Main1(string[] args)
        {
            Print(10);
            Print(0.123);
            Print("Sum = ", 123.4);
        }

        public static void Print(double x)
        {
            Console.WriteLine(x);
        }

        public static void Print(string s, double x)
        {
            Console.WriteLine(s+x);
        }

        public static void Print(int x)
        {
            Console.WriteLine(x);
        }
    }
}
