using ReferenceDLL;

namespace TupleRenameTest
{
    public class UseReferenceDLL1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        private void Test()
        {
            (string Test, int) s1 = (new ReferenceDLL1().Method1().Test, 1);
        }
    }
}