using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH04
{
    internal class P186
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("메서드 호출 전");
            Console.SetCursorPosition(5, 5);
            Console.WriteLine("메서스 호출 후");

            Console.WriteLine("첫번재 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두번재 출력");
            Thread.Sleep(1000);
            Console.WriteLine("세번째 출력");
        }
    }

}

