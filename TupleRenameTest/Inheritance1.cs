namespace TupleRenameTest
{ 
    public class A
    {
    }

    public interface InterfaceImplementation
    {
        (string s, int t, A A) Test1((string s, int t) parameter)
        {
            return (parameter.s, parameter.t, null);
        }
    }

    public class InterfaceImplementation1 : InterfaceImplementation
    {
        public (string s, int t, A A) Test1((string s, int t/*caret*/) parameter1)
        {
            return (parameter1.s, parameter1.t, null);
        }
    }
    public class InterfaceImplementation12 : InterfaceImplementation
    {
        public (string s, int t, A A) Test1((string s, int t) parameter2)
        {
            return (parameter2.s, parameter2.t, null);
        }
    }
    public class InterfaceImplementation13 : InterfaceImplementation
    {
        public (string s, int t, A A) Test1((string s, int t) parameter3)
        {
            return (parameter3.s, parameter3.t, null);
        }
    }
    public class InterfaceImplementation14 : InterfaceImplementation
    {
        public (string s, int t, A A) Test1((string s, int t) parameter4)
        {
            return (parameter4.s, parameter4.t, null);
        }
    }
}