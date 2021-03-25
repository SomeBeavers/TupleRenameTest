using System;
using System.Collections.Generic;

namespace MultiTarget.Playground
{
    public static class ExtensionTest
    {
        public static (Named named, List<(Named named, U u)> list, (Named named, Unnamed)) TupleExtensionMethod<U>(
            this (Named named, List<(Named named,U u)> list, (Named named, Unnamed))
                parameter)
        {
            return (null, null, (null, null));
        }
    }

    public class UseExtensionTest
    {
        private (Named named, List<(Named named, string u)> list, (Named named, Unnamed)) myField;

        public UseExtensionTest(
            (Named named, List<(Named named, string u)> list, (Named named, Unnamed)) 
                myField)
        {
            this.myField = myField;
        }

        private void Test()
        {
            var item3Named = this.myField.TupleExtensionMethod().Item3.named;
            Test2(this.myField.TupleExtensionMethod());
        }

        private void Test2((Named named, List<(Named named, string u)> list, (Named named, Unnamed)) extensionMethod)
        {
            Console.WriteLine(extensionMethod.Item3.named + "");
        }
    }
}