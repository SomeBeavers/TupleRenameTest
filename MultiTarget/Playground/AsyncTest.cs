using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultiTarget.Playground
{
    public class AsyncTest<T>
    {
        public async Task<(T t, List<(U u, string name)> list, (Unnamed1, Named named))> Async1<U>((T t, List<(U u, string name)> list, (Unnamed, Named named)) param = default)
        {
            return (default, null, (null, null));
        }
    }

    public class UseAsyncTest<T>
    {
        private async Task UseAsync1()
        {
            var list = (await new AsyncTest<string>().Async1<T>()).list;
        }
    }

    public class Unnamed1
    {
    }

    public class Named
    {
    }
}