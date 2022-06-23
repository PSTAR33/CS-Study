using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._5
{
    internal class _5_01
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int> { 3, 6, 2, 2, 2, 7 };

            HashSet<int> hset = new HashSet<int>(list);    //  중복 제거하고 집합으로 됨
            SortedSet<int> sset = new SortedSet<int>(hset);   // 집합 내부가 정렬됨
            Stack<int> stack = new Stack<int>(sset);  // 

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}

