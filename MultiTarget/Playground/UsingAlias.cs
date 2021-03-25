
using System.Linq;
using MyAlias1 = System.Collections.Generic.List<(int t/*caret*/, string renamed)>;
namespace MultiTarget.Playground
{
    public class UsingAlias
    {
        private void Test()
        {
            MyAlias1 m = new MyAlias1();
            var s = m.First().renamed;
        }
    }
}