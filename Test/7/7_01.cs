using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._7
{
    internal class _7_01
    {
        static void Main1(string[] args)
        {
            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();

            Console.Write("이름 입력 : ");
            int age = int.Parse(Console.ReadLine()); ;

            Console.Write("이름 입력 : ");
            float height = float.Parse(Console.ReadLine()); ;

            Console.Write("안녕하세요. ");
            Console.Write(name);
            Console.WriteLine("님!");

            Console.Write("나이는 ");
            Console.Write(age);
            Console.WriteLine("세, 키는  ");
            Console.Write(height);
            Console.WriteLine("cm 입니다.");


        }

    }
}
