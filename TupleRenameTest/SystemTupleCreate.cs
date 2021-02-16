using System;

namespace TupleRenameTest
{
    public class SystemTupleCreate
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        private void Test1()
        {
            var primes = Tuple.Create(2, 3, 5, 7, 11, 13, 17, 19);
            Console.WriteLine("Prime numbers less than 20: " +
                              "{0}, {1}, {2}, {3}, {4}, {5}, {6}, and {7}",
                primes.Item1, primes.Item2, primes.Item3,
                primes.Item4, primes.Item5, primes.Item6,
                primes.Item7, primes.Rest.Item1);
        }

        private void Test2()
        {
            var author = new Tuple<string, string, int>("Mahesh Chand", "ADO.NET Programming", 2003);

            // Display author info  
            Console.WriteLine("Author {0} wrote his first book titled {1} in {2}.", author.Item1, author.Item2,
                author.Item3);
        }

        private void Test3()
        {
            var even8 = new Tuple<int, int, int, int, int, int, int, Tuple<double, double, double>>(2, 4, 6, 8, 10, 12,
                14, Tuple.Create(1.1, 1.2, 1.3));
            Console.WriteLine("{0},{1},{2}", even8.Rest.Item1, even8.Rest.Item2, even8.Rest.Item3);
        }

        public void SetTupleMethod(Tuple<string, string, int> tupleAuthor)
        {
            var author2 = tupleAuthor;
            Console.WriteLine("Author:{0}, Title:{1}, Year:{2}.",
                author2.Item1, author2.Item2, author2.Item3);
        }

        public static Tuple<string, string, int> GetTupleMethod()
        {
            // Create a 3-tuple and return it  
            var author = new Tuple<string, string, int>(
                "Mahesh Chand", "Programming C#", 2002);
            return author;
        }

        private void Test4()
        {
            SetTupleMethod(new Tuple<string, string, int>(
                item1: "Mike Gold", item2: "Code UML", item3: 2005));

            var author2 = GetTupleMethod();
            Console.WriteLine("Author:{0}, Title:{1}, Year:{2}.", author2.Item1, author2.Item2, author2.Item3);
        }
    }
}