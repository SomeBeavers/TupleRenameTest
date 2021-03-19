using System.Collections.Generic;

namespace SharedProject1
{
    public class SharedGeneric<T> where T : class, new()
    {
        public (T, List<T> tList, string s) LinkedMethodFromGenericClass((List<T> tList, (int, string s)) parameter)
        {
            return (default, null, null);
        }

        public (string, List<string> tList, string s) NormalMethodFromGenericClass(
            (List<string> tList, (int, string s)) parameter)
        {
            return (default, null, null);
        }

        private void Test()
        {
            (string, List<string> tList, string s) method = new SharedGeneric<A>().NormalMethodFromGenericClass((tList: null, (1, s: "")));
            var methodTList = method.tList;
        }
    }

    internal class A
    {
    }
}