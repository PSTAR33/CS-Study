using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._01단계
{
    internal class Main1_13_1
    {
        static void Main1(string[] args)
        {
                        
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            int m1 = int.Parse(str1);

            int n1 = int.Parse(str2[0].ToString());
            int n2 = int.Parse(str2[1].ToString());
            int n3 = int.Parse(str2[2].ToString());


            int o1 = m1 * n3;
            int o2 = m1 * n2;
            int o3 = m1 * n1;

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.WriteLine(o3);
            Console.WriteLine(o1 + (o2 * 10) + (o3 * 100));
            
        }
    }
}
