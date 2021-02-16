using TupleRenameTest;

namespace MultiTarget
{
    public class UseLinkedMe1
    {
        private void Test()
        {
            var linkedPropS = new LinkMe1().LinkedProp.s_renamed;
        }
    }
}