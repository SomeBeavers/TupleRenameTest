using System.Collections.Generic;

namespace MultiTarget.Playground
{
#if NET5_0
    record RecordTestImpl<T>((T t, string renamwed_2, List<(T t, int)> list1) MyProp, (int, string s) count)
        
        
        : RecordTest<T>(MyProp, count)
    {
    }
#endif

}