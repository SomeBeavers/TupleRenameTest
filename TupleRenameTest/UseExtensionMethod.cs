namespace TupleRenameTest
{
    public class UseExtensionMethod
    {
        private (MyClass MyClass, MyClass23 MyClass23) Test2()
        {
            var t = (name1: "value1", name2: "value2");
            var tName1 = t.name1;

            return (null, null);
        }

        private void Test23()
        {
            var valueTuple = Test2();
            (string S, string S2) ext = valueTuple.MyExt();
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
        public static (string S, string S2) MyExt(this (UseExtensionMethod.MyClass MyClass, UseExtensionMethod.MyClass23 myClass2) s)
        {
            return (null, null);
        }
    }
}