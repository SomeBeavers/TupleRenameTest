namespace TupleRenameTest
{
    public class VariousMembers
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        public static (int myValue, int myValue2) Get() => (myValue: 1, myValue2: 1);
    }
}