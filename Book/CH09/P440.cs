using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CH09
{
    internal class P440
    {
        class Parent { }

        class Child : Parent, IDisposable, IComparable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public int CompareTo(object? obj)
            {
                throw new NotImplementedException();
            }
        }
        static void Main1(string[] args)
        {
            Child child = new Child();
            Parent parent = new Parent();
            IDisposable childAsDisposable = new Child();
            IComparable childAsComparable = new Child();

        }
    }
}
