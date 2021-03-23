using System;
using System.Collections.Generic;
using System.Linq;

namespace TupleRenameTest.Playground
{

    public class ConstructorTest<T> 
    {
        public readonly (T, T t, (List<(int, string coolName)> list, bool isTrue)) myField;

        public ConstructorTest((T, T t, (List<(int, string coolName)> list, bool isTrue)) myField)
        {
            this.myField = myField;
        }
    }

    public class UseConstructorTest
    {
        private ConstructorTest<string> _constructorTest;

        public UseConstructorTest((string, string t, (List<(int, string coolName)> list, bool isTrue)) field)
        {
            _constructorTest = new ConstructorTest<string>(myField: field);
            var te = _constructorTest.myField.Item3.list/*caret*/;
        }
    }

    public interface InterfaceTest
    {
        public (T t, string name, List<(T t, int)> list) Method((string name, int count) parameter)
        {
            return (t: default, name: null, list: null);
        }

        public (T t, string name, List<(T t, int)> list) Method((string name, int count) parameter, string s)
        {
            return Method(parameter);
        }
    }
}