using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub4
{
    internal class Sedan : Car
    {
        // 속성 : 상속관계에서 자식클래스에서 참조할 수 있게 private에서 protected로 수정
        private int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public void Show()
        {
            Console.WriteLine("===================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("차량속도 : "+speed);
            Console.WriteLine("차량베기량 : "+cc);
        }
    }
}
