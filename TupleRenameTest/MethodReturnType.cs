using System;
using SharedProject1;

namespace TupleRenameTest
{
    public class MethodReturnType
    {
        public (int myName, int, int) MethodReturnType1()
        {
            var myName = 1;
            return (myName: myName, 2, 3);
        }

        public (int myName, int, int) MethodReturnType2()
        {
            var sharedProp = new Shared1().SharedProp1;
            Console.WriteLine(sharedProp.s + sharedProp.t);
            var myName = 1;
            var localVar = (testMe: myName, 2, 3);

            return (testMe: myName, 2, 3);
        }

        ((int A, int C), int B) InnerTuple()
        {
            var i = 1;
            return ((i, 1), 2);
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