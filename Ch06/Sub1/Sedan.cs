using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub1
{

    internal class Sedan : Car
    {
        // 속성 : 상속관계에서 자식클래스에서 참조할 수 있게 private에서 protected로 수정
        private int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public override void SpeedDown(int speed)
        {
            Console.WriteLine("Sedan SpeedDown ...");
            base.speed -= speed;
        }

        public override void SpeedUp(int speed)
        {
            Console.WriteLine("Sedan SpeedUp ...");
            base.speed += speed;
        }

        public override void Show()
        {
            Console.WriteLine("===================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("차량속도 : "+speed);
            Console.WriteLine("차량베기량 : "+cc);
            Console.WriteLine("===================");
        }
    }
}
