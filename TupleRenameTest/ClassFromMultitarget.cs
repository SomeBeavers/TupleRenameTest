namespace TupleRenameTest
{
    public class ClassFromMultitarget
    {
        private (string MyClass, int MyClass2) Test1()
        {
            return (/*caret*/MyClass: null, MyClass2: 1);
        }

        private void Test2()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
    }
}