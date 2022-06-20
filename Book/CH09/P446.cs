using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH09
{
    internal class P446
    {
        static void Main1(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"c:\test\test.txt"))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }

            using (StreamReader reader = new StreamReader(@"c:\test\test.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                
            }
        }
    }
}
