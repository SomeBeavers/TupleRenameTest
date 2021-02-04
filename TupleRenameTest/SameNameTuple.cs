using System;

namespace TupleRenameTest
{
    public class SameNameTuple
    {
        (int A, int B) GetPoint()
        {
            var a = 1;
            return (A: a, 2);
        }

        (int A, int B) GetPoint2()
        {
            var a = 1;
            return (A: a, 2);
        }

        private void Test()
        {
            var t1 = (A: 5, B: 10);
            var t2 = (B: 5, A: 10);
        }
    }
}