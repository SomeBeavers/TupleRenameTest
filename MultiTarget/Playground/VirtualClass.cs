using System;
using System.Collections.Generic;

namespace MultiTarget.Playground
{
    public abstract class VirtualClassBase<T>
    {
        public (T t, string name, List<(T t, int)> list) field;

        public VirtualClassBase((T t, string name, List<(T t, int)> list) field)
        {
            this.field = field;
        }

        protected VirtualClassBase()
        {
            throw new System.NotImplementedException();
        }

        public virtual (T t, string name, List<(T t, int)> list) Method()
        {
            return (default, null, null);
        }

        public abstract (T t, string name, List<(T t, int)> list) Method2();
    }

    abstract class VirtualClassBaseImpl<T> : VirtualClassBase<T>
    {
    }

    class VirtualClassBaseImplImpl<T> : VirtualClassBaseImpl<T>
    {
        public override (T t, string name, List<(T t, int)> list) Method2()
        {
            throw new NotImplementedException();
        }
    }

    public class VirtualClass<T> : VirtualClassBase<T>
    {
        public VirtualClass((T t, string name, List<(T t, int)> list) field) : base(field)
        {
        }

        public VirtualClass() : base()
        {
            throw new System.NotImplementedException();
        }

        public override (T t, string name, List<(T t, int)> list) Method()
        {
            return base.Method();
        }

        public override (T t, string name, List<(T t, int)> list) Method2()
        {
            throw new System.NotImplementedException();
        }
    }

    public class UseVirtualClass
    {
        private void Test()
        {
            var name = new VirtualClass<string>().Method2().name;
            var method2 = new VirtualClass<string>().Method2();
            Console.WriteLine(method2.name);
        }
    }
}