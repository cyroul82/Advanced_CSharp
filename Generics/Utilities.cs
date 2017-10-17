using System;

namespace Generics
{

    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //Generic Method of Max
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        //Example to show how to instantiate; To instantiate we need a default constructor, then add another constraint new()
        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}
