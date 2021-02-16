using TupleRenameTest;

namespace TupleRenameTest1
{
    public interface IInheritance3Base33
    {
        (string s, int t, A A) Test1((string s, int t) parameter);
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
    }

    public interface IInheritance3Base : IInheritance3Base33
    {
        new (string s, int t, A A) Test1((string s, int t) parameter);
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
    }

    public interface IInheritance3Base2
    {
        (string s, int t, A A) Test1((string s, int t) parameter);
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
    }

    public class Inheritance4 : IInheritance3Base2, IInheritance3Base
    {
        public (string s, int t, A A) Test1((string s, int t) parameter)
        {
            throw new System.NotImplementedException();
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
    }
}