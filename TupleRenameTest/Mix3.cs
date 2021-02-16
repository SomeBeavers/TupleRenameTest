using System;
using System.Collections.Generic;
using System.Linq;

namespace TupleRenameTest32
{
    public class Generic1<T> where T : class, new()
    {
        public (T t, string u) Test2<U>()
        {
            return (null, default);
        }

        public void Test3()
        {
            var valueTuplesU = Test2<int>().u/*caret*/;
        }
    }

    class MyClass
    {
        public (string s, int t) Test1()
        {
            return (null, 1);
        }

        public void UseTuple1()
        {
            var s = Test1().s/*caret*/;
        }
    }

    class A2
    {
        enum MyEnum
        {
            A, B, C
        }

        private readonly (MyEnum myEnum, MyEnum enum2) field;

        private void UseField1((MyEnum myEnum, MyEnum enum2) parameter)
        {
            bool? a = field switch
            {
                { enum2/*caret*/: MyEnum.A } => true,
                { enum2: MyEnum.B } => false,
                { enum2: MyEnum.C } => null,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}