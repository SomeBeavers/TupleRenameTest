using ReferenceMe;

namespace TupleRenameTest
{
    public class UseReferenceMe1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        private void Test()
        {
            var s = new ReferenceMe1().Method1().s1;
        }
    }
}