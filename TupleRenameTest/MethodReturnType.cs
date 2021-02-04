using System;

namespace TupleRenameTest
{
    public class MethodReturnType
    {
        public (string, string, long) TupleReturnLiteral(long id)
        {
            string name = string.Empty;
            string title = string.Empty;
            long year = 0;

            return (name: name, title, year);
        }

        private void Test1()
        {
            (string name, string, long) tupleReturnLiteral = TupleReturnLiteral(1);
            Console.WriteLine(tupleReturnLiteral.name);
        }
    }
}