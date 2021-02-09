namespace TupleRenameTest
{
    public abstract class Inheritance2Base
    {
        public abstract (string s, int t, A A) Test1((string s, int t) parameter);

        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    class Inheritance2BaseImpl : Inheritance2Base
    {
        public override (string s, int t, A A) Test1((string s, int t) parameter)
        {
            throw new System.NotImplementedException();
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    public class Inheritance2 : Inheritance2Base
    {
        public override (string s, int t, A A) Test1((string s, int t) parameter)
        {
            return (parameter.s, parameter.t, null);
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }
}