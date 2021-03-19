using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject1
{
    class Shared1
    {
        public (string s1, int t1_renamed) SharedProp1 { get; set; }

        public (T, List<T> tList, string s) LinkedMethod<T>((List<T> tList, int, string s) parameter)
        {
            return (default, null, null);
        }
    }
}
