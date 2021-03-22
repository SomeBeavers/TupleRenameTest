using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTarget.Playground
{
    public class Mix2<T> where T : new()
    {
        private readonly (List<T> A1, int B) _s;
        private (List<T> _1, int C) S => _s;

        public (T A1, int B) NewProp => (_s.A1.First(), _s.B);

        private (string S_1, int) Test()
        {
            var (a, b) = S;
            var newPropA = NewProp.A1;
            var sA = S._1;
            return (null, 0);
        }


        private (U A_testrenamed, int B) GetPoint<U>() where U : new()
        {
            var a = new U();


            var useTest = Test();
            var useTestS = useTest.S_1;
            var sLength = useTest.S_1.Length;

            return (a, B: 1);
        }

        public static (NamedClass NamedClass, (IEnumerable<(T, int count)> renamed, Unnamed, string Name)) TestStatic()
        {
            return (null, (null, null, null));
        }

        public static (NamedClass NamedClass, (IEnumerable<(T, int count)> renamed, Unnamed, string Name)) UseStatic()
        {
            return TestStatic();
        }

        public static void UseStatic2()
        {
            (NamedClass NamedClass, (IEnumerable<(T, int count)> renamed, Unnamed, string Name)) testStatic = TestStatic();
            (NamedClass namedClass, (IEnumerable<(T, int count)> renamed, Unnamed, string Name) valueTuple) = TestStatic();
            foreach ((T, int count) foreachTuple in valueTuple.renamed)
            {
                Console.WriteLine(foreachTuple.count);
            }

            testStatic.Item2.renamed.Where(x => x.count/*caret*/ == 1);

            var firstOrDefault = UseStatic().Item2.renamed.FirstOrDefault();
        }

        public async Task<(NamedClass NamedClass, string, List<(T t, bool)> list)> AsyncMethod()
        {
            return (null, null, null);
        }

        public async Task UseAsync()
        {
            Task<(NamedClass NamedClass, string, List<(T t, bool)> list)> asyncMethod = AsyncMethod();
            var enumerable = asyncMethod.Result.list.Select(tuple => tuple.t);
        }
        public class NamedClass
        {
        }

        private void Test2()
        {
            var options = new InnerClass();

                options.MyProperty.ToDictionary(
                    pair => pair.MyType, pair => pair.MyString);
        }

        public class InnerClass
        {
            public (Type MyType/*caret*/, string MyString)[] MyProperty { get; set; }
        }
    }

    public class Unnamed
    {
    }


}