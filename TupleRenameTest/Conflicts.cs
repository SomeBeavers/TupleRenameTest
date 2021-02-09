using System;

namespace TupleRenameTest
{
    public class InClassName
    {
        public InClassName((string a, int test1) var1)
        {
            Console.WriteLine(var1.test1);
            Var1 = var1;
        }
        private void Test2()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        public (string a, int test) Var1 { get; private set; }
    }

    public class Conflicts
    {
        private void Test2()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        private void Test()
        {
            
        }

        private (string, string) Test2(string coolName1, string coolName2)
        {
            (string coolName1, string test) var1 = (coolName1, coolName2);

            void NewFunction(InClassName inClassName)
            {
                var coolName2Length = inClassName.Var1.test;
            }

            NewFunction(new InClassName(( 
                "", 
                1)));
            return var1;
        }
    }
}