using System.Collections.Generic;

namespace MultiTarget.Playground
{
    public interface IInterfaceImplementation<T>
    {
        (T t, string name, List<(T t, int)> list) Method();
        (T t, string name, List<(T t, int)> list) Method2();
    }
    public interface IInterfaceImplementation2<T>
    {
        (T t, string name, List<(T t, int)> list) Method();
        (T t, string name, List<(T t, int)> list) Method2();
    }

    class InterfaceImplementation1<T> : IInterfaceImplementation<T>, IInterfaceImplementation2<T>
    {
        (T t, string name, List<(T t, int)> list) IInterfaceImplementation<T>.Method()
        {
            throw new System.NotImplementedException();
        }

        public (T t, string name, List<(T t, int)> list) Method()
        {
            throw new System.NotImplementedException();
        }

        public (T t, string name, List<(T t, int)> list) Method2()
        {
            throw new System.NotImplementedException();
        }
    }

    public abstract class InterfaceImplementation<T> : IInterfaceImplementation<T>
    {
        public (T t, string name, List<(T t, int)> list) field;

        public InterfaceImplementation((T t, string name, List<(T t, int)> list) field)
        {
            this.field = field;
        }

        protected InterfaceImplementation()
        {
            throw new System.NotImplementedException();
        }

        public virtual (T t, string name, List<(T t, int)> list) Method()
        {
            return (default, null, null);
        }

        public abstract (T t, string name, List<(T t, int)> list) Method2();
    }
}