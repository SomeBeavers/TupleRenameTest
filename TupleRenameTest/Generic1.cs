#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace TupleRenameTest
{
    public class UseGen
    {
        private void Test()
        {
            var generic1 = new Generic1<A12>(("", Age: new A12()));
            generic1.myTuple.Age = null;
            generic1.myTuple.Age = null;
        }
    }

    internal class A12
    {
    }


    public class Generic1<T> where T: class, new()
    {
        private int _tupleU;
        public (string, T Age) myTuple;

        public Generic1((string, T Age) myTuple)
        {
            Console.WriteLine(myTuple.Age);
            Console.WriteLine(this.myTuple.Age);
            this.myTuple = myTuple;
        }

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

    public struct MyStruct<K, V> : IEnumerable<(K Key/*caret*/, V Value)>
    {
        public IEnumerator<(K Key, V Value)> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void Test()
        {
            var key = this.First().Key;
        }
    }
}