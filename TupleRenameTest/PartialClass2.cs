using System;

namespace TupleRenameTest
{
    public partial class PartialClass1
    {
        public partial (string s, int t1) Test1(string s, string s2)
        {
            if (true)
            {
                return (null,  0);
            }
            else
            {
                return (s: null, 0);
            }

            return (null, 0);
        }

        public void UseTuple2()
        {
            //Func<string, string, (string s, int t1)> test1 = Test1;
            //test1.Invoke("","2").s;

            var valueTuple = Test2();
            (((int t, bool b), long l), string s) valueTuple2 = Test2();

            var s = NewFunction();
            var boolString = valueTuple.Item1.Item1.b.ToString();
            var sString = valueTuple.s.ToString();

            string NewFunction()
            {
                var boolString = valueTuple.Item1.Item1.b.ToString();
                return boolString;
            }
        }

        private (((int t, bool b), long l), string s) Test2()
        {
            return (((0, false), 0), null);
        }

        private (int t_renamed, string s_renamed) Test3((bool b, long l) parameter)
        {
            return (1, null);
        }

        private void Test()
        {
            var test3 = Test3((false, 0));
            NewFunction();
            var valueTuple = Test1("", "").s;

            void NewFunction()
            {
                test3.t_renamed.ToString();
            }
        }
    }
}