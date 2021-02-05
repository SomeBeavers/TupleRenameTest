namespace MultiTarget
{
    public class PreprocessorTest
    {
        public (string s, int t) Test1(string s, string s2)
        {
            return (null, 0);
        }
        public (string s, int t) Test1(string s)
        {
            return (null, 0);
        }

        private void Test2()
        {
            var tuple = Test1("");

            var  newTuple = tuple;
            var newTupleS = newTuple.s;
        }
#if NET5_0
        private void Test21()
        {
            var tuple = Test1("");

            var newTuple = tuple;
            var newTupleS = newTuple.s;
        }
#endif
    }
}