using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_03
    {
        static void Main1(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if(a % 4 == 0)
            {
                if(a % 400 == 0)
                {
                    Console.WriteLine(1);
                }
                else if(a % 100 == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(1);
                }    
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
