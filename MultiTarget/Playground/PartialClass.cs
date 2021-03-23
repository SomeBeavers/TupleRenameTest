using System;
using System.Collections.Generic;

namespace MultiTarget.Playground
{
#if NET5_0

    public partial class PartialClass<T> where T : new()
    {
        private (string renamed, int) field;

        public partial (string name, T t) PartMethod(List<(string s, int t)> list);
        public partial (string name, T t) PartMethod2((string s, int t) a);
    }

#endif

    public class MyAttribute: Attribute
    {
        private (string name, int) field;
        public MyAttribute((string name, int) field)
        {
            this.field = field;
        }
    }

}