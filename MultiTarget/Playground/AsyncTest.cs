using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTarget.Playground
{
    public class AsyncTest<T>
    {
        public async Task<(T t_1, List<(U u, string name)> list1, (Unnamed1, Named renamed))> Async1<U>((T t, List<(U u, string name)> list, (Unnamed, Named named)) param = default)
        {
            return (default, null, (null, null));
        }
    }

    public class UseAsyncTestBase<T>
    {
        protected static Task<(string t_1, List<(T u, string name)> list1, (Unnamed1, Named renamed))> Async1 => new AsyncTest<string>().Async1<T>();
    }

    public class UseAsyncTest<T> : UseAsyncTestBase<T>
    {
        //private async Task UseAsync1()
        //{
        //    var list = (await new AsyncTest<string>().Async1<T>()).list;
        //}

        private async Task UseAsync2()
        {
            List<(T u, string name)> list = (await Async1).list1;
            if (Async1.IsCompleted)
            {
                (T t_1, List<(T u, string name)> list1, (Unnamed1, Named renamed)) valueTuple = (new AsyncTest<T>().Async1<T>().Result);
                var item3Named = valueTuple.Item3.renamed;


                IEnumerable<(T u, string name)> named = 
                    valueTuple.list1
                    .Where(x => x.name == "");
                IEnumerable<(T u, string name)> named2 = 
                    (Async1.Result).list1
                    .Where(x => x.name == "");
            }
        }
    }

    public class Unnamed1
    {
    }

    public class Named
    {
        public string A { get; set; }
    }
}