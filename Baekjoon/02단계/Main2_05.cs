using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon._02단계
{
    internal class Main2_05
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split();
            int h = int.Parse(time[0]);
            int m = int.Parse(time[1]);

            int s = h * 60 + m;
            int t = s - 45;

            if (t < 0)
            {
                t = 1440 + t;
            }
            Console.WriteLine("{0} {1}", t / 60, t % 60);
            // Console.WriteLine(t / 60+" "+ t % 60);
            // Console.WriteLine($"{t / 60} {t % 60}");

        }
    }
}
