using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH04
{
    internal class Class1
    {
        static void Main1(string[] args)
        {
            int[] array = new int[10];

            foreach(var item in array)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < 10; i++)
            {
                Console.Write("출력");
            }
            Console.WriteLine("");
            
            int j = 0;
            while (j<10)
                {
                Console.Write("출력");
                j++;
                }


        }
    }
}
