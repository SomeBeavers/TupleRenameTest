namespace MultiTarget
{
    class MultiTestClass1
    {
        private (MyClass MyClass, MyClass2 MyClass2) Test1()
        {
            return (MyClass: null, MyClass2: null);
        }

        private void Test2()
        {
            (MyClass MyClass, MyClass2 MyClass2) valueTuple = Test1();
            var valueTupleMyClass = valueTuple.MyClass;
        }

        internal class MyClass2
        {
        }

        internal class MyClass
        {
        }
    }
}