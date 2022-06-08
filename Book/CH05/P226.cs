using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH05
{
    class Product
    {
        public string name;
        public int price;
    }
    internal class P226
    {
        
        static void Main1(string[] args)
        {
            Product product = new Product();

            product.name = "스마트폰";
            product.price = 1000000;

            Console.WriteLine("product 이름 : "+product.name);
            Console.WriteLine("product 가격 : "+product.price);
        }
    }
}
