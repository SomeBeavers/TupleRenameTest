namespace TupleRenameTest
{
    public interface IInheritance3Base
    {
        (string s, int t, A A) Test1((string s/*caret*/, int t) parameter);
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    public interface IInheritance3Base2
    {
        (string s, int t, A A) Test1((string s, int t) parameter);
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    public class Inheritance4: IInheritance3Base2, IInheritance3Base
    {
        public (string s, int t, A A) Test1((string s, int t) parameter)
        {
            throw new System.NotImplementedException();
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        private void Test(string parameter)
        {
            (string s1, int t) var1 = ("", 1);
        }
    }
}