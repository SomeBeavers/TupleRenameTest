using System;
using System.Collections.Generic;

namespace NugetLib
{
    public class NugetLib
    {
        public (T, T t, string s, (List<T> Tlist, int count)) NugetLibMethod<T>(params (string, int t, T tt)[] p)
        {
            return (default, default, null, (null, 0));
        }
    }
}
