using System;
using System.Collections.Generic;

namespace MultiReferencedLib
{
    public class MultiReferencedLib1
    {
        public (string s121, int t1) Property { get; set; }
#if NET5_0


        public (bool b, string s) Test1(string s)
        {
            Console.WriteLine(Property.s121);
            return (false, null);
        }
#else

        public (bool b1, string s) Test1(string s)
        {
            Console.WriteLine(Property.s121);
            return (false, null);
        }
#endif

    }
}
