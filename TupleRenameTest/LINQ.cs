using System;
using System.Linq;

namespace TupleRenameTest
{
    public class LINQ
    {
        private void Test()
        {
            var dates = new[]
            {
                DateTime.UtcNow.AddHours(-1),
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
            };

            foreach (var a in
                dates.Select(
                    date => (Formatted: $"{date:MMM dd, yyyy at hh:mm zzz}", date.Ticks)))
            {
                Console.WriteLine($"Ticks: {a.Ticks}, formatted: {a.Formatted}");
            }
        }
    }
}