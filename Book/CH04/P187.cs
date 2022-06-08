using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH04
{
    internal class P187
    {
        static void Main1(string[] args)
        {
            int X = 1;
            while (X < 50)
            {
                //화면을 지우고 커서를 이동합니다.
                Console.Clear();
                Console.SetCursorPosition(X, 5);

                //출력합니다.
                if (X % 3 == 0)
                    Console.WriteLine(" __@");
                else if (X % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                // 100밀리초 정지하고 x를 증가합니다.
                Thread.Sleep(100);
                X++;
            }
        }
    }
}
