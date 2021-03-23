using System.Collections.Generic;

namespace MultiTarget.Playground
{
#if NET5_0
    public interface IRecordTest<T>
    {
        (T t, string renamwed_2, List<(T t, int)> list1) MyProp { get; init; }
        (int, string s) count { get; init; }
    }

    public record RecordTest<T>((T t, string renamwed_2, List<(T t, int)> list1) MyProp, (int, string s) count) : IRecordTest<T>
    {
        private readonly (T t, string renamwed_2, List<(T t, int)> list1) _myProp = MyProp;

        public override string ToString()
        {
            return $"{nameof(MyProp)}: {MyProp.renamwed_2}, {nameof(count)}: {count}";
        }

        public (T t, string renamwed_2, List<(T t, int)> list1) MyProp
        {
            get => _myProp;
            init => _myProp = value;
        }
    }

    public class UseRecord
    {
        private void Test<U>() where U : new()
        {
            var recordTest = (IRecordTest<U>)new RecordTestImpl<U>((new U(), "", null), (1, ""));
            var myPropList1 = recordTest.MyProp.list1;
            //var _recordTestMyProp = recordTest with {MyProp = (new U(), "cool", null)};
            //var i = (recordTest with {MyProp = (new U(), "cool", null)}).MyProp.renamwed_2.Length;

            var recordTest2 = new RecordTest<U>((new U(), "", null), (1, ""));
            var _recordTestMyProp2 = recordTest2 with {MyProp = (new U(), "cool", null)};
            var i2 = (recordTest2 with {MyProp = (new U(), "cool", null)}).MyProp.renamwed_2.Length;
        }
    }
#endif
}