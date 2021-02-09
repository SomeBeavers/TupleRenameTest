﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

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
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }

    class C
    {
        (int x, string y1) Test((int x1, string y1) valueTuple)
        {
            M(Test); // use QF change signature of 'Test' here
            valueTuple.x1.ToString();
            return (0, null);
        }
        void M(Func<(int a, string b), (int c, string e)> a)
        {
            var parameterType = a.GetMethodInfo().GetParameters().First().ParameterType;
            var enumerable = new List<(int, string)>().Select(x => a(x));
            IEnumerable<(string d, int c)> enumerable2 = new List<(int, string)>().Select(x =>
            {
                var a1 = a(x);
                return (d: a1.e, a1.c);
            });

            var s = enumerable2.First().d;
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
    }
}