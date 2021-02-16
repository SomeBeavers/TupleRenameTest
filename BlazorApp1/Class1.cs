namespace BlazorApp1
{
    public class Class1
    {
        public (string s, int t1_renamed) MyTest()
        {
            return (null, 0);
        }
    }

    public class MyClass
    {
        public (int t_renamed, string) currentCount1 = (1, "");

        private void Test()
        {
            (int t_renamed, string) a = (currentCount1.t_renamed/*caret*/, currentCount1.Item2);
        }
    }
}