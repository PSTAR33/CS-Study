using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_04
    {
        static void Main1(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            int n1 = int.Parse(num1);
            int n2 = int.Parse(num2);

            if(n1 > 0 && n2 > 0)
            {
                Console.WriteLine(1);
            }
            if (n1 < 0 && n2 > 0)
            {
                Console.WriteLine(2);
            }
            if (n1 < 0 && n2 < 0)
            {
                Console.WriteLine(3);
            }
            if (n1 > 0 && n2 < 0)
            {
                Console.WriteLine(4);
            }
        }
    }
}
