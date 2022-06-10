using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_06
    {
        static void Main1(string[] args)
        {
            string[] time = Console.ReadLine().Split();
            string time1 = Console.ReadLine();
            int h = int.Parse(time[0]);
            int m = int.Parse(time[1]);
            int t = int.Parse(time1);

            int num1 = h * 60 + m;
            int num2 = num1 + t;

            if(num2 > 1440)
            {
                num2 = num2 - 1440;
            }
            Console.WriteLine("{0} {1}",+num2/60,+num2%60);

        }
    }
}
