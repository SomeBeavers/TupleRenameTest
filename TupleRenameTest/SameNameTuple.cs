using System;

namespace TupleRenameTest
{
    public class SameNameTuple
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        public class A
        {

            public void Test21_UseField()
            {
                var s = new UseField2().FieldWithManyUsages1.s121;
            }
        }

        public (A a, int t) MyProp { get; set; }


        (int A, int B) GetPoint()
        {
            var a = 1;
            return (A: MyProp.a.GetHashCode(), 2);
        }

        (A a, int MyProp) GetPoint2(Func<int, (int i, int b12)> tuple)
        {
            var i = 1;
            var (i1, b13) = tuple(i);
            var valueTuple = tuple(i);
            valueTuple.i.ToString();
            valueTuple.b12.ToString();
            return (null, 2);
        }

        private void Test()
        {
            GetPoint2(delegate(int someCoolName)
            {
                Console.WriteLine(someCoolName);
                var a = (renamed: someCoolName, someCoolName23: 2);
                Console.WriteLine(a.renamed);
                Console.WriteLine(a.someCoolName23);
                return (someCoolName, 2);
            });
            var t1 = (A: 5, B: 10);
            var t2 = (B: 5, A: 10);
        }
    }
}