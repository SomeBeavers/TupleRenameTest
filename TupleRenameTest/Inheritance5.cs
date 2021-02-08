using TupleRenameTest;

namespace TupleRenameTest1
{
    public interface IInheritance3Base33
    {
        (string s, int t, A A) Test1((string s, int t) parameter);
    }

    public interface IInheritance3Base : IInheritance3Base33
    {
        new (string s, int t, A A) Test1((string s, int t) parameter);
    }

    public interface IInheritance3Base2
    {
        (string s, int t, A A) Test1((string s, int t) parameter);
    }

    public class Inheritance4 : IInheritance3Base2, IInheritance3Base
    {
        public (string s, int t, A A) Test1((string s, int t) parameter)
        {
            throw new System.NotImplementedException();
        }
    }
}