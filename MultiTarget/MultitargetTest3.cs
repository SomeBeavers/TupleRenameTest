﻿using System;
using SharedProject1;

namespace MultiTarget
{
    public class MultitargetTest3
    {
        private void Test()
        {
            MyInnerClass2 myInnerClass2;
            MyInnerClass myInnerClass;
            (MyInnerClass2 Item, MyInnerClass myInnerClass) test2 = (TestNew(), TestNew2());
            var innerClass2 = test2.myInnerClass;

            var sharedProp = new Shared1().SharedProp1;
            Console.WriteLine(sharedProp.s + sharedProp.t);

            var test1 = new PreprocessorTest().Test1("");

            var test1S = test1.s;
        }

        private MyInnerClass2 TestNew()
        {
            throw new System.NotImplementedException();
        }

        private MyInnerClass TestNew2()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class MyInnerClass2
    {
    }

    internal class MyInnerClass
    {
    }
}