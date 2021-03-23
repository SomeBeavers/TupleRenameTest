using System;
using System.Collections.Generic;
using System.Linq;

namespace TupleRenameTest.Playground1
{
    public class RenameReturn<T>
    {
        public (string s, InnerClass inner, int) Test1()
        {
            return (null, null, 0);
        }

    }

    public abstract class VirtualClassBase<T>
    {
        public (T t, string name, List<(T t, int)> list) field;

        public VirtualClassBase((T t, string name, List<(T t, int)> list) field)
        {
            this.field = field;
        }

        public virtual (T t, string name, List<(T t, int)> list) Method()
        {
            return (default, null, null);
        }

        public abstract (T t, string name, List<(T t, int)> list) Method2();
    }

    public class VirtualClass<T> : VirtualClassBase<T>
    {
        public VirtualClass((T t, string name, List<(T t, int)> list) field) : base(field)
        {
        }

        public override (T t, string name, List<(T t, int)> list) Method2()
        {
            throw new System.NotImplementedException();
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

        public void Parameter3(in List<(int t, string)> myList)
        {
            Console.WriteLine(myList.First().t);
        }


        public void Use(List<(int t, string name)> b)
        {
            foreach (var b1 in b)
            {
                var b1T = b1.t;
                var b1Name = b1.name;
            }

            Parameter3(in b);
        }
    }

    public class InnerClass
    {

    }

    class MyClass
    {
        public void Parameter2((string u, int sameName, List<int> list, string) p)
        {
            p = (u: default, sameName: default, list: null, null);
            Console.WriteLine(p.list.First());
        }

        public void UseParameter2((int, int sameName/*caret*/, bool, bool) p)
        {
            //Parameter2(p);
        }
    }
}