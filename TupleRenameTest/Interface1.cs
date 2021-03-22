using System;

namespace TupleRenameTest
{
    public interface Interface1
    {
        public (string s, int t, bool b1) MyProp { get; set; }

        public void Test1((string s, int t, bool b) param)
        {
            MyProp = param;
            Console.WriteLine(MyProp.b1);
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    class Nterface2 : Interface1
    {
        public (string s, int t, bool b1) MyProp { get; set; }

        public void Test1((string s, int t, bool b) param)
        {

        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    class Nterface1 : Interface1
    {
        public (string s, int t, bool b1) MyProp { get; set; }
        public void Test1((string s, int t, bool b) param)
        {
            throw new NotImplementedException();
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    class UseInterface1
    {
        private void Test()
        {
            Interface1 myVar = new Nterface1();

            while (myVar.MyProp.b1/**/)
            {
                
            }
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }
}