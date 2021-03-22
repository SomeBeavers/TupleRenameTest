using System;
using System.Collections.Generic;

namespace TupleRenameTest.Playground
{
    public class RenameReturn<T>
    {
        public (string s, InnerClass inner, int) Test1()
        {
            return (null, null, 0);
        }

        public (List<T> genericList, T name, (List<T> genericList, int), int) Test2()
        {
            return (null, default, (null, 0), 0);
        }

        public (Dictionary<U, T> dictionary, int) Test3<U>()
        {
            return (null, 0);
        }

        private void Use()
        {
            (string s, InnerClass inner, int) useTest1 = Test1();
            var useTest1S = useTest1.s;
            var innerClass = Test1().inner;
            (InnerClass inner, int) newTuple = (useTest1.inner, 1);

            Console.WriteLine(newTuple.inner);
        }
    }

    class UseRenameReturn<T>
    {
        private void Use()
        {
            (string s, InnerClass inner, int) useTest1 = new RenameReturn<T>().Test1();
            var useTest1S = useTest1.s;
            var innerClass = new RenameReturn<T>().Test1().inner;
            (InnerClass inner, int) newTuple = (useTest1.inner, 1);

            Console.WriteLine(newTuple.inner);

            var a = new RenameReturn<T>().Test2();
            a.Item3.genericList.ForEach(x => Console.WriteLine(x));

            (Dictionary<string, T> dictionary, int) b = new RenameReturn<T>().Test3<string>();
            b.dictionary.Add("", default);
        }
    }

    public class InnerClass
    {
    }
}