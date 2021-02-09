using System;

namespace TupleRenameTest
{
    public abstract class Inheritance3Base
    {
        public virtual (string s, int t, A A) Test1((string s, int t) parameter)
        {
            return (null, 0, null);
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    class Inheritance3BaseImpl : Inheritance3Base
    {
        public override (string s, int t, A A) Test1((string s, int t) parameter)
        {
            Console.WriteLine(parameter.s);
            return base.Test1(parameter);
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    public class Inheritance3 : Inheritance3Base
    {
        public override (string s, int t, A A) Test1((string s, int t) parameter)
        {
            Console.WriteLine(parameter.s);
            throw new System.NotImplementedException();
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }
}