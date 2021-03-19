using System.Collections.Generic;

namespace TupleRenameTest
{
    public class LinkMe1
    {
        public (string s_renamed1, int t) LinkedProp { get; set; }

        public (T, List<T> tList, string s) LinkedMethod<T>((List<T> tList, int, string s) parameter)
        {
            return (default, null, null);
        }
    }

    public class GenericLinkMe<T> where T: class, new()
    {
        public (T, List<T> tList, string s) LinkedMethod((List<T> tList, int, string s) parameter)
        {
            return (default, null, null);
        }
    }
}