using System;
using System.Collections.Generic;
using MultiReferencedLib;

namespace UseMulti3
{
    public class Class1
    {
        private void UseMulti()
        {
            (bool b1, string s12) valueTuple = new MultiReferencedLib1().Test1(("", t1: 1));

            var valueTupleS = valueTuple.s12;

            (A, List<A> tList, string s) linkedMethod = new MultiReferencedLib1().LinkedMethod<A>((tList: null, 1, s: ""));

        }
    }

    internal class A
    {
    }
}
