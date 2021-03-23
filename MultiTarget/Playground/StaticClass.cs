using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiTarget.Playground
{
    public static class StaticClass
    {
        private static (string Name, MyInnerClass, bool isTrue, Dictionary<(int t1, int t2), string> dictionary) StField = ("", null, false, null);

        static StaticClass()
        {
            var t1 = StField.dictionary.Keys.First().t1;
        }

        public static (string Name, bool isTrue) ExtensionMethod(this (string Name, MyInnerClass, bool isTrue, Dictionary<(int t1, int t2), string> dictionary) p)
        {
            return (p.Name, p.isTrue);
        }
    }

    public class UseStaticClass
    {
        private static (string Name, MyInnerClass, bool isTrue, Dictionary<(int t1, int t2), string> dictionary) StField = ("", null, false, null);
        private (string Name, bool isTrue) _extensionMethod;

        private void Test()
        {
            _extensionMethod = StField.ExtensionMethod();
            Console.WriteLine(_extensionMethod.Name);
        }
    }
}