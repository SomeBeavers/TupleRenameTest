using System;

namespace TupleRenameTest
{
    public class MethodReturnType
    {
        public (int myName, int, int) MethodReturnType1()
        {
            var myName = 1;
            return (myName: myName, 2, 3);
        }


        public (string, string, long) TupleReturnLiteral(long id)
        {
            string name = string.Empty;
            string title = string.Empty;
            long year = 0;

            var tupleReturnLiteral = (name: name, title, year);

            var l = tupleReturnLiteral.year;
            return tupleReturnLiteral;
        }

        (int A, int B) GetPoint()
        {
            return (A: 1, 2);
        }

        private void Test1()
        {
            var tupleReturnLiteral = TupleReturnLiteral(1);
            Console.WriteLine(tupleReturnLiteral.Item3);
        }
    }
}