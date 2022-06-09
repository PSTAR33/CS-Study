using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * 날짜 : 2022/06/09
 * 이름 : 박세환
 * 내용 : 증가, 감소 연산자 연습문제
 */
namespace Test._1
{
    internal class _1_04
    {
        static void Main1(string[] args)
        {
            int num = 1;
            int result;

            result = num++;
            Console.WriteLine("result : "+result);

            result = ++num;
            Console.WriteLine("result : " + result);

            result = num--;
            Console.WriteLine("result : " + result);

            result = --num;
            Console.WriteLine("result : " + result);

        }
    }
}
