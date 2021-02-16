using System;
using System.Collections.Generic;

namespace TupleRenameTest
{
    public class MethodParameter
    {
        public void TestOut(out (string, int Age, ((bool b_1_1, long l), string n/*caret*/)) o)
        {
            string n = null;
            o = (n, 0, ((false, 0), n));
            o.Item3.n = "";
        }

        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        private void Test1()
        {
            var limitsLookup = new Dictionary<int, (int Min, int)>()
            {
                [2] = (4, 10),
                [4] = (10, 20),
                [6] = (0, 23)
            };

            if (limitsLookup.TryGetValue(4, out (int Min, int) limits))
            {
                Console.WriteLine($"Found limits: min is {limits.Min}, max is {limits.Item2}");
            }
        }
    }
}