using System;

namespace TupleRenameTest
{
    public class UseExtensionMethod
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        private (MyClass MyClass, MyClass23 MyClass23) Test2()
        {
            // t
            var t1 = (name12: "value1", name2: "value2");
            var tName1 = t1.name12;

            return (null, null);
        }

        private void Test23()
        {
            var valueTuple = Test2();
            var ext = valueTuple.MyExt().S21;
            var ext2 = MyClassExt.MyExt(s: valueTuple).S21;
        }

        public class MyClass
        {
            public string S;
            public string S2;
        }

        internal class MyClass2
        {
        }

        public class MyClass23
        {
        }
    }

    public static class MyClassExt
    {
        public static (string S, string S21) MyExt(this (UseExtensionMethod.MyClass MyClass, UseExtensionMethod.MyClass23 myClass2) s)
        {
            Console.WriteLine(s.MyClass);
            return (null, null);
        }
    }
}