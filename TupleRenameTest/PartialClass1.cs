using System;

namespace TupleRenameTest
{
    public partial class PartialClass1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        public partial  (string s, int t1) Test1(string s, string s2);

        public void UseTuple1()
        {
            var valueTuple = Test2();
            (((int t, bool b), long l), string s) valueTuple2 = Test2();

            var s = NewFunction();

            string NewFunction()
            {
                var boolString = valueTuple.Item1.Item1.b.ToString();
                return boolString;
            }
        }

        public (int myName, int, int) MethodReturnType1()
        {
            var myName = 1;
            return (myName: myName, 2, 3);
        }

        public void UseTuple3()
        {
            var test3 = Test3(parameter: (false, 0));
            Converter<(bool b, long l), (int t, string s)> method3_1 = Test3;
            Func<(bool b, long l), (int t, string s)> method3_2 = Test3;

            method3_1.Invoke((false, 0)).s[1].GetHashCode();
            for (int i = 0; i < method3_1.Invoke((false, 0)).t; i++)
            {
                Console.WriteLine(method3_2.Invoke((false, 0)).s.EndsWith("1"));
                NewMethod(test3);
                NewFunction();
            }

            void NewFunction()
            {
                test3.t_renamed.ToString();
            }
        }

        private static void NewMethod((int t, string s) test3)
        {
            test3.t.ToString();
        }
    }
}