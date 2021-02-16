namespace TupleRenameTest
{
    public class UseLinkedMe1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        private void Test()
        {
            var linkedPropS = new LinkMe1().LinkedProp.s_renamed;
        }
    }
}