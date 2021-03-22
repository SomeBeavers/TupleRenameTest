using System;

namespace TupleRenameTest.Playground
{
    public class Mix2
    {
        private readonly (int A, int B) _s;
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