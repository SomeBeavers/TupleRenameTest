#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace TupleRenameTest
{
    public class Generic1<T> where T: class, new()
    {
        private int _tupleU;

        public void Test1<U>([NotNull](T? t, U u) par)
        {
            (T? t, U u) var = (new T(), par.u);

            Console.WriteLine(par.u);
        }

        public (T? t, U u/*caret*/) Test2<U>(params (T? t, U u)[] par)
        {
            return (null, default);
        }

        public void Test2()
        {
            var valueTuples = Test2<int>((null, 1), (new T(), 2));

            var valueTuplesU = valueTuples.u;
        }

        public (T? t, U u/*caret*/)[] Test3<U>(params (T? t, U u)[] par)
        {
            return new (T? t, U u)[] { };
        }

        private void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }
}