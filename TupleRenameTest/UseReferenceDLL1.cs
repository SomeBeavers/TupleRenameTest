using ReferenceDLL;

namespace TupleRenameTest
{
    public class UseReferenceDLL1
    {
        private void Test()
        {
            var s1 = (s1_renamed: new ReferenceDLL1().Method1().Test, Test:1);
        }
    }
}