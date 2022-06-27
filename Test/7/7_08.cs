using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._7
{
    internal class _7_08
    {
        static void Main(string[] args)
        {
            string name = "홍길동";
            int age = 27;

            string str1 = "안녕 " + name + ", 올해 " + age + "세 입니다.";
            Console.WriteLine(str1);

            string str2 = string.Format("안녕 {0}, 올해{1}세 입니다.", name, age);
            Console.WriteLine(str2);
            
            string str3 = $"안녕 {name}, 올해 {age}세 입니다.";
            Console.WriteLine(str3);

            string str4 = string.Concat("안녕", name, ", 올해", age, "세 입니다.");
            Console.WriteLine(str4);

            string[] amimals = { "Tiger", "Eagle", "Shark", "Lion", "Rabbit" };

            string result1 = string.Concat(amimals);
            Console.WriteLine(result1);

            string result2 = string.Join("-", amimals);
            Console.WriteLine(result2);



        }
    }
}
