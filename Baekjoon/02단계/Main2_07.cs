using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_07
    {
        static void Main1(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int n1 = int.Parse(num[0]);
            int n2 = int.Parse(num[1]);
            int n3 = int.Parse(num[2]);

            if(n1 == n2 && n2 == n3)
            {
                int a = 10000 + n1 * 1000;
                Console.WriteLine(a);
            }
            else if (n1 == n2)
                {
                    int b = 1000 + n1 * 100;
                    Console.WriteLine(b);
                }
            else if (n1 == n3)
                {
                    int b = 1000 + n1 * 100;
                    Console.WriteLine(b);
                }
            else if (n2 == n3)
                {
                    int b = 1000 + n2 * 100;
                    Console.WriteLine(b);
                }
           
            else if(n1 != n2 && n2 != n3 && n1 != n3)
            {
                if(n1 < n2)
                {
                    n1 = n2;
                    if (n1 < n3)
                        n1 = n3;
                }

                int c = n1 * 100;
                Console.WriteLine(c);
            }
        }
    }
}

