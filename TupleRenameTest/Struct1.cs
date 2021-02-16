using System;
using TupleRenameTest;

namespace TupleRenameTest1
{
    public class Struct1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        protected (Class1 class1, Class2 class2, Class3 class3) field1;

        public Struct1((Class1 class1, Class2 class2, Class3 class3) field1)
        {
            this.field1 = field1;
            Console.WriteLine(this.field1.class1);
        }
        public Struct1(Class1 cl)
        {
            this.field1 = field1;
        }
    }

    class Struct1Impl : Struct1
    {
        public Struct1Impl((Class1 class1, Class2 class2, Class3 class3) field1) : base(field1.class1)
        {
            var valueTuple = field1;
            var valueTupleClass1 = valueTuple.class1;
            Console.WriteLine(base.field1.class1);
        }
    }

    public class Class3
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
    }

    public class Class2
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
    }

    public class Class1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
    }
}