using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH09
{
    internal class P442
    {
        static void Main1(string[] args)
        {
            File.WriteAllText(@"c:\test\test.txt", "문자열을 파일에 씁니다.");
            Console.WriteLine(File.ReadAllText(@"c:\test\test.txt"));
        }
    }
}
