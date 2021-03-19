using System.Collections.Generic;

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
            var linkedPropS = new LinkMe1().LinkedProp.s_renamed1;
            (A, List<A> tList, string s) linkedMethod = new LinkMe1().LinkedMethod<A>((tList:null, 1, s: ""));
            (A, List<A> tList, string s) valueTuple = new GenericLinkMe<A>().LinkedMethod((tList: null, 1, s: ""));
        }
    }
}