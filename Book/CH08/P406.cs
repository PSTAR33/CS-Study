using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH08
{

    internal class P406
    {
        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;


            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                this.testA = "초기화";
                this.testB = "초기화";
            }

            public Point(int x, int y, string test)
            {
                this.x = x;
                this.y = y;
                this.testA = test;
                this.testB = test;
            }
        }

        static void Main(string[] args)
        {
            Point point = new Point(0, 0);

            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
        }
    }
}
