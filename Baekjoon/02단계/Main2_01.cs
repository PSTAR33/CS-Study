using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_01
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            int num1 = int.Parse(str[0]);
            int num2 = int.Parse(str[1]);

            if(num1 > num2)
            {
                Console.WriteLine(">");
            }
            else if(num1 < num2)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}
