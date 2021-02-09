using System;
using System.Linq;
using TupleRenameTest;
using MyAlias = System.Collections.Generic.List<System.Tuple<int, string, int>>;
using MyAlias1 = System.Collections.Generic.List<(int t, string s)>;

namespace ConsoleApp5
{
    class Program1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        static void Main1(string[] args)
        {
            MyAlias x;
            x = new MyAlias();

            // TODO: no rename
            var item1 = x.First().Item1;
            Console.WriteLine("Hello World!");
        }
        static void Main2(string[] args)
        {
            MyAlias1 x;
            x = new MyAlias1();

            var item1 = x.First().t;
            Console.WriteLine("Hello World!");
        }
    }
}