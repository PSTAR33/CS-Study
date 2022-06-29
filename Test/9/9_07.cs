using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._9
{
    internal class _9_07
    {
        static void Main1(string[] args)
        {
            DrawPyramid(3);
            DrawPyramid(5);
            DrawPyramid(7);
        }

        public static void DrawPyramid(int n)
        {
            for ( int i=1; i<=n; i++)
            {
                for (int j = i; j < n; j++)
                    Console.Write(" ");
                for (int k = 1; k<2*i; k++)
                    Console.Write("*");

                Console.WriteLine();

            }
        }
    }
}
