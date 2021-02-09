using System;

namespace TupleRenameTest
{
    public class TupleAssignment
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        private void Test()
        {
            (int I, double D) t1 = (17, 3.14);
            (double First, double Second) t2 = (I: 0.0, D: 1.0);
            t2 = t1;
            Console.WriteLine($"{nameof(t2)}: {t2.First} and {t2.Second}");

            (double A, double B) t3 = (2.0, 3.0);
            t3 = t2;
            Console.WriteLine($"{nameof(t3)}: {t3.A} and {t3.B}");
        }
    }
}