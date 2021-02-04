namespace TupleRenameTest
{
    public class RenameTypeRelatedTuple
    {
        class MyClass // rename here
        {
            public string S;
            public string S2;
        }

        internal class MyClass2
        {
        }

        private (MyClass MyClass, MyClass2 MyClass2) Test2() // maybe suggest MyClass tuple
        {
            return (null, null);
        }
    }
}