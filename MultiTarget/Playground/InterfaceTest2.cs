using System;
using System.Collections.Generic;

namespace MultiTarget.Playground
{
    public interface InterfaceTest2 
    {
        public (string Name, int Count) SimpleMethod((string ParameterName, bool) parameter)
        {
            return (null, 0);
        }
    }

    internal interface INterfaceTest21
    {
        (List<string> list, int count, MyInnerClass) MethodFromInterface(params (string name_renamed, int t1)[] param);
    }

    internal interface INterfaceTest2 : INterfaceTest21
    {
        public void Test();
    }

    class NterfaceTest2 : InterfaceTest2, INterfaceTest2
    {
        public (string Name, int Count) SimpleMethod((string ParameterName, bool) parameter)
        {
            throw new System.NotImplementedException();
        }

        (List<string> list, int count, MyInnerClass) INterfaceTest21.MethodFromInterface(params (string name_renamed, int t1)[] param)
        {
            foreach (var tuple in param)
            {
                Console.WriteLine(tuple.name_renamed);
            }

            return (null, 0, null);
        }
        (List<string> list, int count, MyInnerClass) MethodFromInterface(params (string name, int t)[] param)
        {
            foreach (var tuple in param)
            {
                Console.WriteLine(tuple.name);
            }

            return (null, 0, null);
        }

        public void Test()
        {
            ((INterfaceTest21) this).MethodFromInterface((name_renamed: "", t1:1), (name_renamed: "", 2));
            MethodFromInterface((name: null, 1), (name: null, 2));
            throw new NotImplementedException();
        }
    }

    class MyClass
    {
        void MethodFromInterface(params (string name, int t)[] param)
        {
        }

        public void Test()
        {
            MethodFromInterface((name: null, 1), (name: null, 2));
            throw new NotImplementedException();
        }
    }
}