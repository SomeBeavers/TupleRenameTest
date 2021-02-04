using System;

namespace TupleRenameTest
{
    public class InitializeVar
    {
        private void Test()
        {
            // tuple initialization expression
            var t = (Sum: 4.5, Count: 3);
            Console.WriteLine($"Sum of {t.Count} elements is {t.Sum}.");
            Console.WriteLine($"Sum of {t.Item1} elements is {t.Item2}.");

            // definition of a tuple type
            (double Sum, int Count) d = (4.5, 3);
            Console.WriteLine($"Sum of {d.Count} elements is {d.Sum}.");
            Console.WriteLine($"Sum of {d.Item1} elements is {d.Item2}.");

            // inferred from the name of the corresponding variable in a tuple initialization expression
            var sum = 4.5;
            var count = 3;
            var t2 = (sum, count);
            Console.WriteLine($"Sum of {t2.count} elements is {t2.sum}.");
            Console.WriteLine($"Sum of {t2.Item1} elements is {t2.Item2}.");

            // The candidate name is a duplicate of another tuple field name (implicit).
            var sum2 = 4.5;
            var count2 = 3;
            var t23 = (sum2, sum2);
            Console.WriteLine($"Sum of {t23.Item1} elements is {t23.Item2}.");

            // The candidate name is a duplicate of another tuple field name (explicit).
            var sum3 = 4.5;
            var count3 = 3;
            var t233 = (sum3, sum3: count3);
            Console.WriteLine($"Sum of {t233.Item1} elements is {t233.sum3}.");
            Console.WriteLine($"Sum of {t233.Item1} elements is {t233.Item2}.");

            // The candidate name is a member name of a tuple type, for example, Item3, ToString, or Rest.
            // TODO: rename variable sum31 here -> tuple initialization is inserted
            var sum31 = 4.5;
            var ToString = 3;
            var t2331 = (sum31, ToString);
            Console.WriteLine($"Sum of {t2331.sum31} elements is {t2331.ToString()}.");
            Console.WriteLine($"Sum of {t2331.Item1} elements is {t2331.Item2}.");

        }
    }
}