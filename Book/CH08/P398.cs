using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH08
{
    internal class P398
    {
        public int this[int i]
        {
            // Products products = new Product();
            // products[i] 할 때에 호출
            get { return i; }
            // products[i] = 10 할 때에 호출
            set { Console.WriteLine( i +"번째 상품 설정"); }
        }
        
    }
}
