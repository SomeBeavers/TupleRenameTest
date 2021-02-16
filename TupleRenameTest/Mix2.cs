using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TupleRenameTest12
{
    public class A
    {
    }

    public interface InterfaceImplementation
    {
        (string s, int t, A item1) Test1((string s, int /*caret*/) parameter)
        {
            return (parameter.s, 0, null);
        }
    }

    public class InterfaceImplementation1 : InterfaceImplementation
    {
        public (string s, int t, A item1) Test1((string s, int ) parameter1)
        {
            return (parameter1.s, 0, null);
        }
    }
    public class InterfaceImplementation12 : InterfaceImplementation
    {
        public (string s, int t, A item1) Test1((string s, int ) parameter2)
        {
            return (parameter2.s, 0, null);
        }
    }
    public class InterfaceImplementation13 : InterfaceImplementation
    {
        public (string s, int t, A item1) Test1((string s, int ) parameter3)
        {
            return (parameter3.s, 0, null);
        }
    }
    public class InterfaceImplementation14 : InterfaceImplementation
    {
        public virtual (string s, int t, A item1) Test1((string s, int ) parameter4)
        {
            return (parameter4.s, 0, null);
        }
    }

    class InterfaceImplementation14Impl : InterfaceImplementation14
    {
        public List<(List<(string s_renamed, int t)> MyComponent, int MyComponent2, int MyComponent31)> Test1()
        {
            return null;
        }

        public void UseTuple1()
        {
            var s = Test1().First().MyComponent.First().s_renamed;
            foreach (var tuple in Test1().ToArray())
            {
                foreach (var list in tuple.MyComponent)
                {
                    Console.WriteLine(list.s_renamed);
                }
            }
        }


        public void UseTuple2()
        {
            var valueTuple = Test2();

            var boolString = valueTuple.Item1.Item1.b_a111.ToString();
            var sString = valueTuple.s.ToString();
        }

        private (((int t, bool b_a111), long l), string s) Test2()
        {
            return (((0, b:false), 0), null);
        }
        private async Task<(string s1, int t)> GetTupleAsync(List<(string s_new_name, int t)> p)
        {
            var valueTuple = (s: p.FirstOrDefault().s_new_name, p.Count);
            Console.WriteLine(valueTuple.s);
            return (p.FirstOrDefault().s_new_name, p.Count);
        }
        public override (string s, int t, A item1) Test1((string s, int) parameter4)
        {
            return base.Test1(parameter4);
        }
    }
}