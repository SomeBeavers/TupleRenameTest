using System;
using System.Collections.Generic;
using System.Linq;

namespace TupleRenameTest
{
    public class MethodReturnType3
    {
        public void UseTuple2()
        {
            var valueTuple = Test2();

            var boolString = valueTuple.Item1.Item1.b.ToString();
            var sString = valueTuple.s.ToString();
        }

        private (((int t, bool b), long l), string s) Test2()
        {
            return (((0, false), 0), null);
        }

        public List<(List<(string /*caret*/s, int t)> MyComponent, int MyComponent2, int MyComponent31)> Test1()
        {
            return null;
        }

        public void UseTuple1()
        {
            var s = Test1().First().MyComponent.First().s;
            foreach (var tuple in Test1().ToArray())
            {
                foreach (var list in tuple.MyComponent)
                {
                    Console.WriteLine(list.s);
                }
            }
        }
    }
}