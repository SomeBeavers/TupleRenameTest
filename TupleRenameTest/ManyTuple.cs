﻿using System;

namespace TupleRenameTest
{
    public class ManyTuple
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        private void Test()
        {
            // Rest
            var t =
                (1, 2, 3, 4, 5, 6, 7, A1:8, 9, 10,
                    11, 12, 13, 14, 15, 16, 17, 18,
                    19, 20, 21, 22, 23, 24, 25, 26, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                    11, 12, 13, 14, 15, 16, 17, 18,
                    19, 20, A: 21, 22, 23, 24, 25, 26);
            Console.WriteLine(t.Rest.Item1);
            Console.WriteLine(t.A);
        }
    }
}