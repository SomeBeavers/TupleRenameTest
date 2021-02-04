namespace TupleRenameTest
{
    public class Discard
    {
        internal class MyClass2
        {

        }

        internal class MyClass23
        {

        }

        private (UseExtensionMethod.MyClass MyClass, MyClass23 MyClass23) Test2()
        {

            var t = (name1: "value1", name2: "value2");
            var tName1 = t.name1;

            return (null, null);
        }

        private void Test23()
        {
            var (_, _) = Test2();
        }
    }
}