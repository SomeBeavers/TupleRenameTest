using System;
using System.Collections.Generic;

namespace MultiReferencedLib
{
    public class MultiReferencedLib1
    {
        public (string coolName, int t1) Property { get; set; }
#if NET5_0


        public (bool b12, string s) Test1(string s)
        {
            Console.WriteLine(Property.coolName);
            return (false, null);
        }
#else

        public (bool b1, string s12) Test1((string, int t1) tupleParameter)
        {
            Console.WriteLine(Property.coolName);
            return (false, null);
        }

        public (T, List<T> tList, string s) LinkedMethod<T>((List<T> tList, int, string s) parameter)
        {
            return (default, null, null);
        }
#endif

    }
}
