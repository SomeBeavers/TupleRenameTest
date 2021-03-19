namespace ConsoleApp1
{
    public class LocalFunction1
    {
        private void Test1(
            (int t, int t2, int t1, int t3, int t4, int t5, int t6, int t7, int t8, int t9, int t10, int t11, int t12, int t13, int t141) parameter)
        {

            var localVar = (i:"", t141: parameter.t141);



            int NewFunction(
                (int t, int t2, int t1, int t3, int t4, int t5, int t6, int t7, int t8, int t9, int t10, int t11, int t12, int t13,
                    int t141) valueTuple)
            {
                var i = valueTuple.Rest.Item1;
                valueTuple.t141++;
                parameter.t141++;
                localVar.t141++;
                var localVar2 = localVar;
                localVar2.t141++;
                var localVar22 = localVar2;
                localVar22.t141++;
                var localVar23 = localVar22;
                localVar23.t141++;
                var localVar24 = localVar23;
                localVar24.t141++;
                return i;
            }

            var restItem1 = NewFunction(parameter);
        }
    }
}