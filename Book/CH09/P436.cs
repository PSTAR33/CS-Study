using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH09
{
    internal class P436
    {
        interface IBasic
        {
            int TestInstanceMethod();
            int TestProperty { get; set; }
        }

        class TestClass : IBasic
        {
            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }
            
            public int TestProperty
            {
                get
                {
                    throw new NotImplementedException();
                }
                set
                {
                    throw new NotImplementedException();
                }

            }

            
        }
        static void Main1(string[] args)
        {
            IBasic basic = new TestClass();
        }
    }
}
