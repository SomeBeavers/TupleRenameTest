using System.Collections.Generic;

namespace MultiTarget.Playground
{
#if NET5_0
    public partial class PartialClass<T> where T : new()
    {
        public void Test()
        {
            field.renamed = "";
        }

        public partial (string name, T t) PartMethod(List<(string s, int t)> list)
        {
            return (null, new T());
        }
        public partial (string name, T t) PartMethod2((string s, int t) a)
        {
            return (null, new T());
        }
    }
#endif
}