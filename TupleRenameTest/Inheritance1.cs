namespace TupleRenameTest
{ 
    public class A
    {
        private void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    public interface InterfaceImplementation
    {
        (string s, int t, A A) Test1((string s1, int t1) parameter)
        {
            return (s: parameter.s1, t: parameter.t1, null);
        }
        private void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    public class InterfaceImplementation1 : InterfaceImplementation
    {
        public (string s, int t, A A) Test1((string s1, int t1) parameter1)
        {
            return (s: parameter1.s1, t: parameter1.t1, null);
        }
        private void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }
    public class InterfaceImplementation12 : InterfaceImplementation
    {
        public (string s, int t, A A) Test1((string s1, int t1) parameter2)
        {
            return (s: parameter2.s1, t: parameter2.t1, null);
        }
        private void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }
    public class InterfaceImplementation13 : InterfaceImplementation
    {
        public (string s, int t, A A) Test1((string s1, int t1) parameter3)
        {
            return (s: parameter3.s1, t: parameter3.t1, null);
        }
        private void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }
    public class InterfaceImplementation14 : InterfaceImplementation
    {
        public (string s, int t, A A) Test1((string s1, int t1) parameter4)
        {
            return (s: parameter4.s1, t: parameter4.t1, null);
        }
        private void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }
}