using System;
using System.Collections.Generic;

namespace TupleRenameTest.Playground1
{
    public class RenameReturn<T>
    {
        public (string s, InnerClass inner, int) Test1()
        {
            return (null, null, 0);
        }

    }

    class UseRenameReturn
    {
        private void Use()
        {
            var useTest1 = new RenameReturn<string>().Test1();
            (InnerClass inner, int) newTuple = (useTest1.inner, 1);

            Console.WriteLine(newTuple.inner);
        }

        (string A, int B) GetPoint()
        {
            return ("", 1);
        }

        void Test2()
        {
            var valueTuple = GetPoint();
            (string A, int) myVar = (valueTuple.A, 10);
            Console.WriteLine(myVar.A);
        }
    }

    public class InnerClass
    {
    }
}