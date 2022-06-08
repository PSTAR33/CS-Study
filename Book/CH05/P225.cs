using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH05
{
    internal class P225
    {
        class User
        {
            public string name;
            public string password;
            public string address;
            public string phoneNumber;
            public DateTime regDate;
        }

        class Product
        {
            public string name;
            public int price;
        }

        static void Main1(string[] args)
        {
            Product product = new Product();
        }
    }
}
