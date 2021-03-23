using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiTarget.Playground
{
    public class ConstructorTestBase<T>
    {
        public void Deconstruct(out (T, T t_renamed, (List<(int, string coolName)> list, bool IsFalse)) myField, out (T, T t, (List<(int, string coolName)> list, bool isTrue)) myField2)
        {
            myField = _myField;
            myField2 = _myField2;
        }

        private (T, T t_renamed, (List<(int, string coolName)> list, bool IsFalse)) _myField;
        private (T, T t, (List<(int, string coolName)> list, bool isTrue)) _myField2;

        public ConstructorTestBase((T, T t_renamed, (List<(int, string coolName)> list, bool IsFalse)) myField)
        {
            _myField = myField;
        }
    }

    class ConstructorTestBaseImpl<T> : ConstructorTestBase<T>
    {
        public ConstructorTestBaseImpl((T, T t_renamed, (List<(int, string coolName)> list, bool IsFalse)) myField) : base(myField)
        {
        }
    }

    public class ConstructorTest<T> : ConstructorTestBase<T>
    {
        public readonly (T, T t_renamed, (List<(int, string coolName)> list, bool IsFalse)) myField;

        public ConstructorTest((T, T t_renamed, (List<(int, string coolName)> list, bool IsFalse)) myField, string s) : this(myField)
        {
            this.myField = myField;
            Console.WriteLine(myField.Item3.IsFalse);
        }

        public ConstructorTest((T, T t_renamed, (List<(int, string coolName)> list, bool IsFalse)) myField) : base(myField)
        {
            this.myField = myField;
            Console.WriteLine(myField.Item3.IsFalse);
        }
    }

    public class UseConstructorTest
    {
        private ConstructorTest<string> _constructorTest;

        public UseConstructorTest((string, string t_renamed, (List<(int, string coolName)> list, bool IsFalse)) field)
        {
            _constructorTest = new ConstructorTest<string>(myField: field, "");
            NewFunction();
            var te = (_constructorTest.myField.t_renamed, _constructorTest.myField.Item3.list.First().coolName);
            te.coolName = "";

            void NewFunction()
            {
                var (myField, myField2) = _constructorTest;
                var myFieldT = myField.t_renamed;
            }
        }

        private void Test(bool @true)
        {
            var isTrue = @true/*caret*/;
            var item3 = _constructorTest.myField.Item3;
            var item3IsTrue = item3.IsFalse;
            Console.WriteLine(item3.list.Where(x => x.coolName == "coolName"));
        }

        private void Test2()
        {
            var field = _constructorTest.myField;
            Test(field.Item3.IsFalse);
            Console.WriteLine(field.t_renamed);
        }
    }
}