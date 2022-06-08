using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH05
{
        internal class P227
    {
        static void Main1(string[] args)
        {

            //인스턴스를 생성합니다.
            Product product = new Product();

            //인스턴스 변수를 변경합니다.
            product.name = "감자";
            product.price = 2000;

            //인스턴스 변수를 출력합니다.
            Console.WriteLine(product.name + " : " + product.price + "원");


        }
    }

}
