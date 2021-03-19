
using System.Collections.Generic;
using TupleRenameTest;

namespace MultiTarget
{
    public class UseLinkedMe1
    {
        private void Test()
        {
            var linkedPropS = new LinkMe1().LinkedProp.s_renamed1;
            (A, List<A> tList, string s) linkedMethod = new LinkMe1().LinkedMethod<A>((tList: null, 1, s: ""));

        }
    }

    internal class A
    {
    }
}