using System;
using System.Collections.Generic;
using System.Linq;

namespace TupleRenameTest.Playground
{
    public class Mix2
    {
        private readonly (int A, int B) _s;
        private static IEnumerable<(string NewProp, int Count)> _newList = new List<(string NewProp, int Count)>();
        private (int A, int B) FieldProp => _s;
        public (int A, int B) PrintField
        {
            get
            {
                Console.WriteLine(_s.A);
                return _s;
            }
        }

        private void Test()
        {
            var newPropA = PrintField.A;
            var sA = FieldProp.A/*caret*/;
        }

        private static void SelectMethod(IEnumerable<(string NewProp, int Count)> s)
        {
            var list = new List<InnerClassNew>().Select(x => (x.NewProp, x.Count));

            _newList = list.Where(x => x.Count > 0).Select(x => (x.NewProp, Count: x.Count + 1));

            var valueTuples = _newList as (string NewProp, int Count)[] ?? _newList.ToArray();
            foreach (var tuple in valueTuples)
            {
                Console.WriteLine($"{tuple.NewProp}");
                Console.WriteLine($"{tuple.Count}");
            }

            var count = valueTuples.First().Count;
            var i = s.First().Count;
            s = valueTuples;
            var i1 = s.First().Count;
        }

        internal record InnerClassNew(string NewProp/*caret*/, int Count)
        {
        }
        (string A, int B) GetPoint()
        {
            return ("", 1);
        }

        void Test2()
        {
            var valueTuple = GetPoint();
            (string renamed, int Named) myVar = (valueTuple.A, 10);
            Console.WriteLine(myVar.renamed/*caret*/);
        }
    }
}