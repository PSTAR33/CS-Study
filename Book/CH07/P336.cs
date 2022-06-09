using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH07
{
    class Animal1
    {
        public int Age { get; set; }
        public Animal1() { this.Age = 0; }

        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잘을 잡니다.");
        }
    }

    class Dog1 : Animal1
    {
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("왈왈 짖습니다.");
        }

    }
    class Cat1 : Animal1
    {
        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
    internal class P336
    {

    }
}
