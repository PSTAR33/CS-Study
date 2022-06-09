using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 날짜 : 2022/06/09
 * 이름 : 박세환
 * 내용 : 입출력 연습문제
 */
namespace Test._1
{
    internal class _1_02
    {
        static void Main1(string[] args)
        {
            int year;
            int birth;
            string name;

            Console.Write("올해 년도 입력 : ");
            year = int.Parse(Console.ReadLine());

            Console.Write("태어난 년도 입력 : ");
            birth = int.Parse(Console.ReadLine()); // birth = Convert.ToInt32(Console.ReadLine()); 도 가능

            Console.Write("이름 입력 : ");
            name = Console.ReadLine();

            int age = year - birth;

            Console.Write("{0}님 안녕하세요.\n당신은 올해 만 {1}세 입니다.", name, age);
        }
    }
}
