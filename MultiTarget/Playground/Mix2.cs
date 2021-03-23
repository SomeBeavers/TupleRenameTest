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
            var asyncMethod = AsyncMethod();
            var result = asyncMethod.Result;
            var enumerable = result.list.Select(tuple => tuple.t);
            result.NamedClass = new NamedClass();
            var resultNamedClass = result.NamedClass;
            Console.WriteLine(AsyncMethod().Result.NamedClass/*caret*/);
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
            public (Type MyType, string MyString)[] MyProperty { get; set; }
        }

        public void Parameter1(Task<(NamedClass NamedClass, string, List<(T t, bool)> list)> parameter)
        {
            parameter.Result.list.ForEach(x => Console.WriteLine(x.t));
        }

        public void UseParameter1()
        {
            const Task<(Mix2<T>.NamedClass NamedClass, string, List<(T t, bool)> list)> parameter = null;
            Parameter1(parameter);
        }

        public void Parameter2<U>(out (U u, T t, List<int> list, string) p)
        {
            p = (u: default,  t: default, list: null, null);
            Console.WriteLine(p.list.FindLastIndex(1,Match));
        }

        public void UseParameter2<U>((U u, T t, List<int> list, string) p)
        {
            var p1 = (p.u, t: new T(), new List<int>(), "comment");
            Parameter2(out p1);
            Parameter2(out p);
            p.t = new T();
            p1.t = new T();
        }

        private bool Match(int obj)
        {
            throw new NotImplementedException();
        }

        public void Parameter3(in List<(int t, string)> myList)
        {
            Console.WriteLine(myList.First().t);
        }

        public void Parameter4(ref (Unnamed, (NamedClass named1, string name), T t, bool) parameter, string s)
        {
            parameter2 = parameter;
            parameter2 = (null, (null, name:null), new T(), false);
            parameter2.Item2.name = "";
            parameter.Item2.name = "";
        }

        public void Parameter5()
        {
        }


        public void Use(List<(int t, string name)> b)
        {
            foreach (var b1 in b)
            {
                var b1T = b1.t;
                var b1Name = b1.name;
            }

            Parameter3(in b);
            (Unnamed, (NamedClass named1, string name), T t, bool) parameter = (null, (null, null), default, false);
            Parameter4(ref parameter);
            //Parameter4(ref parameter2);
            //Parameter4(ref parameter2);

            var parameter3 = parameter;
            Console.WriteLine(parameter3.Item2.name);
            Parameter4(ref parameter3);
            Parameter4(ref parameter3, "");
        }

        private void Parameter4(ref (Unnamed, (NamedClass named1, string name), T t, bool) parameter)
        {
            throw new NotImplementedException();
        }

        private static (Unnamed, (NamedClass named1, string name), T t, bool) parameter2;
    }

    public class Unnamed
    {

    }


}