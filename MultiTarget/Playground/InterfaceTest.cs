using System.Collections.Generic;

namespace MultiTarget.Playground
{
#if NET5_0
    public partial interface IInterfaceTest<T> where T : new()
    {
        (T t, string name, List<(T t, int)> list) Method( (string name, int count) parameter);
        (T t, string name, List<(T t, int)> list) Method((string name, int count) parameter, string s);
    }

    public interface IInterfaceTest2<T> where T : new()
    {
        (T t, string name, List<(T t, int)> list) Method2((T name, int count) parameter);
        (T t, string name, List<(T t, int)> list) Method3((string name, int count) parameter);
    }

    class InterfaceTest2<T> : IInterfaceTest2<T> where T : new()
    {
        public (T t, string name, List<(T t, int)> list) Method2((T name, int count) parameter)
        {
            throw new System.NotImplementedException();
        }

        public (T t, string name, List<(T t, int)> list) Method3((string name, int count) parameter)
        {
            throw new System.NotImplementedException();
        }
    }

    public partial interface IInterfaceTest<T> : IInterfaceTest2<T>
    {
    }

    public interface InterfaceTest<T> : IInterfaceTest<T> where T: new()
    {
        public new (T t, string name, List<(T t, int)> list) Method((T name, int count) parameter)
        {
            return (t: default, name: null, list: null);
        }


        public new (T t, string name, List<(T t, int)> list) Method((string name, int count) parameter, string s)
        {
            //var method2 = Method2(parameter);
            (string, int) tuple = ("", 1);
            var method3 = Method3(tuple);
            var method3_1 = Method3(parameter);
            return Method(parameter);
        }

        (T t, string name, List<(T t, int)> list) Method2((T name, int count) parameter);
        new (T t, string name, List<(T t, int)> list) Method3((string name, int count) parameter);
    }

    class NterfaceTest<T> : InterfaceTest<T> where T : new()
    {
        private InterfaceTest<T> _interfaceTestImplementation;
        public (T t, string name, List<(T t, int)> list) Method((string name, int count) parameter)
        {
            return _interfaceTestImplementation.Method(parameter);
        }

        public (T t, string name, List<(T t, int)> list) Method((string name, int count) parameter, string s)
        {
            return _interfaceTestImplementation.Method(parameter, s);
        }

        (T t, string name, List<(T t, int)> list) InterfaceTest<T>.Method2((T name, int count) parameter)
        {
            return _interfaceTestImplementation.Method2(parameter);
        }

        public (T t, string name, List<(T t, int)> list) Method3((string name, int count) parameter)
        {
            return _interfaceTestImplementation.Method3(parameter);
        }

        public (T t, string name, List<(T t, int)> list) Method2((T name, int count) parameter)
        {
            return _interfaceTestImplementation.Method2(parameter);
        }

        (T t, string name, List<(T t, int)> list) InterfaceTest<T>.Method3((string name, int count) parameter)
        {
            return _interfaceTestImplementation.Method3(parameter);
        }
    }
#endif

}