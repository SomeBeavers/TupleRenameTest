using System;

namespace TupleRenameTest
{
    public class Switch1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        class C
        {
            void M(MyEnum myEnum)
            {
                var y = (myEnum, myEnum) switch
                {
                    (MyEnum.A, MyEnum.A) => (/*caret*/Test1: MyEnum.A, Test2: MyEnum.A),
                    (MyEnum.A, MyEnum.B) => (Test1: MyEnum.A, Test2: MyEnum.B)
                };
                Console.WriteLine(y.Test1);
            }
        }
        enum MyEnum
        {
            A, B
        }
    }
}