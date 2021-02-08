using ReferenceDLL;

namespace TupleRenameTest
{
    public class UseReferenceDLL1
    {
        private void Test()
        {
            (string Test, int) s1 = (new ReferenceDLL1().Method1().Test, 1);
        }
    }
}