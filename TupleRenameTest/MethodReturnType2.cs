namespace TupleRenameTest
{
    public class MethodReturnType2
    {
        public (CreatedClass ParameterName_Test, string b1) MethodReturnType2Test1()
        {
            var a = new CreatedClass();
            (CreatedClass c, string d) methodReturnType2Test1 = (c: a, d:"null");
            return methodReturnType2Test1;
        }

        public (int test, int b) MethodReturnType2Test3()
        {
            return (test: 0, b: 0);
        }

        private (string s, int t1) Test1(string s, string s2)
        {
            if (true)
            {
                return (s1: null, t1:0);
            }
            else
            {
                return (s1: null, t1: 0);
            }

            return (s1: null, t1:0);
        }

        public int MethodReturnType2Test4()
        {
            var newcmpl = MethodReturnType2Test3().b;
            return MethodReturnType2Test3().Item1 + newcmpl;
        }


        public void MethodReturnType2Test2()
        {
            var s = MethodReturnType2Test1().ParameterName_Test + MethodReturnType2Test1().b1;
            var s2 = (MethodReturnType2Test1().ParameterName_Test,MethodReturnType2Test1().b1);
            var s2ARenamed = ((a: s2.ParameterName_Test, 1), (1,2),3);
            var item1B = s2ARenamed.Item1.a;
        }
    }

    public class CreatedClass
    {
    }
}