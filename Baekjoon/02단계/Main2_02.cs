using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_02
    {
        static void Main1(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(str);

            if (90 <= num && num <= 100)
            {
                Console.WriteLine("A");
            }
            else if (80 <= num && num <= 89)
            {
                Console.WriteLine("B");
            }
            else if (70 <= num && num <= 79)
            {
                Console.WriteLine("C");
            }
            else if (60 <= num && num <= 69)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

        }
    }
}
