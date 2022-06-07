using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH02
{
    internal class P96
    {
        static void Main1(string[] args)
        {
            int number = 10;
            Console.WriteLine(number++);
            Console.WriteLine(++number);
            Console.WriteLine(number--);
            Console.WriteLine(--number);

            int number1 = 10;
            Console.WriteLine(number1);
            number1++;
            number1++;
            Console.WriteLine(number1);
            Console.WriteLine(number1);
            number1--;
            number1--;
            Console.WriteLine(number1);
        }
    }
}
