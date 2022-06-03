using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._01단계
{
    internal class Main1_13
    {
        static void Main1(string[] args)
        {
                        
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();


            int n1 = int.Parse(num1);
            int m1 = int.Parse(num2);
            int p1 = (m1 % 100) % 10;
            int p2 = (m1 % 100) / 10;
            int p3 = m1 / 100;

            int o1 = n1 * p1;
            int o2 = n1 * p2;
            int o3 = n1 * p3;

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);
            Console.WriteLine(o1 + (o2 * 10) + (o3 * 100));
            
        }
    }
}
