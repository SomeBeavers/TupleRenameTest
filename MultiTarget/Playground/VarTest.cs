using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiTarget.Playground
{
#if NET5_0
    

    public class VarTest<T> where T: new()
    {
        public List<(T t, Named named, Unnamed)> MyProp
        {
            get => _myProp;
            set => _myProp = value;
        }


        private List<(T t, (string name, int count), bool)> myList;
        private (string name, int count) _item2Name;
        private List<(T t, Named named, Unnamed)> _myProp;

        public void Test<U>() where U: T
        {
            foreach (var valueTuple1 in myList)
            {
                var tuple = ((U, (string name, int count), bool)) valueTuple1;
                var valueTuple = tuple;
                var tuple1 = myList.First();
                tuple1 = tuple;
                var item2Count = tuple1.Item2.count;
                _item2Name = tuple.Item2;
                var item2NameCount = _item2Name.count;
            }

            foreach (var tuple in MyProp)
            {
                var tupleNamed = tuple.named;
            }
        }


        private void Test2()
        {
            var dates = new[]
            {
                DateTime.UtcNow.AddHours(-1),
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
            };

            foreach (var a in
                dates.Select(date => (Formatted: $"{date:MMM dd, yyyy at hh:mm zzz}", date.Ticks)))
            {
                Console.WriteLine($"Ticks: {a.Ticks}, formatted: {a.Formatted}");
                Console.WriteLine($"Ticks: {a.Ticks}, formatted: {a.Formatted}");
                Console.WriteLine($"Ticks: {a.Ticks}, formatted: {a.Formatted}");
                Console.WriteLine($"Ticks: {a.Ticks}, formatted: {a.Formatted}");
            }

            SelectMethod();
        }

        private static void SelectMethod()
        {
            var list = new List<InnerClassNew>().Select(x => (x.NewProp, x.Count));

            var newList = list.Where(x => x.Count > 0).Select(x => (x.NewProp, Count: x.Count + 1));

            foreach (var tuple in newList)
            {
                Console.WriteLine($@"{nameof(tuple.NewProp)}");
            }
        }

        internal record InnerClassNew(string NewProp/*caret*/, int Count)
        {
        }

        public ((int A1, int), int renamed) GetPoint()
        {
            var a = 1;
            return ((A: a, 1), renamed:2);
        }
    }



    class UseVarTest<U> where U:new()
    {
        private void Test() => new VarTest<U>().MyProp.Select(x => x.named);
        private void Test2<T>() where T: new()
        {
            new VarTest<T>().MyProp.Select(x => x.named);
            ((int A1, int), int renamed) valueTuple = new VarTest<T>().GetPoint();
        }
    }
#endif
}