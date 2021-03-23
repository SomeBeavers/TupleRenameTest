using System.Collections.Generic;

namespace MultiTarget.Playground
{
    public struct StructTest<T>
    {
        public StructTest((T t, string name, List<(T t, int)> list) myProp)
        {
            MyProp = myProp;
        }

        public (T t, string name, List<(T t, int)> list) MyProp { get; set; }
    }
}