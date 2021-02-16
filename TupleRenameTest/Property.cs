using System;

#nullable enable

namespace TupleRenameTest
{
    public class Property
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        public static (int t1, int myValue23) Get()
        {
            var tuple = (s1: 1, t2: 1);
            tuple.s1++;
            if (tuple.t2 > 0)
            {
                tuple.s1++;
            }

            return tuple;
        }

        public static (LetsNameComponentLikeClass? t1, string s) myCoolTuple = (null, "");

        public class LetsNameComponentLikeClass
        {
        }

        enum MyEnum
        {
            A,B,C
        }

        private readonly (MyEnum myEnum, MyEnum enum2) field;

        private void UseField1((MyEnum myEnum, MyEnum enum2) parameter)
        {
            switch (field, true)
            {
                case ({ } tuple, _) when tuple.myEnum == MyEnum.A:
                    break;
                case {field: {myEnum: MyEnum.B}}:
                    break;
                case ({myEnum: MyEnum.C}, _):
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            bool? a = field switch
            {
                {enum2: MyEnum.A} => true,
                {enum2: MyEnum.B} => false,
                {enum2: MyEnum.C} => null,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public void UseProperty1(LetsNameComponentLikeClass t)
        {
            var a = new LetsNameComponentLikeClass();
            var getter = Get();
            var myValue = getter.t1;
            var s = getter.myValue23.ToString();
            string mys = $"myV: {getter.myValue23}";

            var myS2 = nameof(getter.t1.GetHashCode);

            string? letsNameComponentLikeClass;
            if (myCoolTuple.t1 != null)
                letsNameComponentLikeClass = myCoolTuple.t1.ToString();
            else
                letsNameComponentLikeClass = null;
        }
    }
}