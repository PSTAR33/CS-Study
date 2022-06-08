using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH04
{
    internal class P175
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int k = 8; k > i + 1; k--)
                    Console.Write(""); ;
                for (int j = 0; j < i + 1; j++)
                    Console.Write('\n');
            }
        }
    }
}
