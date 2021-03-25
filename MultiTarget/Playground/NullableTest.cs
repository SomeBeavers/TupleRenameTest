using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MultiTarget.Playground
{
    #nullable enable
    public interface INullableTest
    {
        //[NotNull]
        //(Named? nullableNamed, string?, List<(string? name, int? count)> list)? Property { get; set; }

        //(Named? nullableNamed, string?, List<(string? name, int? count)> list)? Method(
        //    (Named? nullableNamed, string?, List<(string? name, int? count)> list1)? p);


        Named? Method2((Named? named, string)? parameter1, (Named named, string) parameter2, Named? p3);
    }

    public class NullableTest<T> : INullableTest where T: new()
    {
        public NullableTest((Named? nullableNamed, string?, List<(string? name, int? count)> list) property)
        {
            Property = property!;
        }

        public (Named? nullableNamed, string?, List<(string? name, int? count)> list)? Property { get; set; }


        public (string? s, int? t) Field;
        public NullableTest((string s/*caret*/, int? t) field)
        {
            Field = field;
        }

        public (Named? nullableNamed, string?, List<(string? name, int? count)> list)? Method(
            (Named? nullableNamed, string?, List<(string? name, int? count)> list1)? p)
        {
            return null;
        }

        [return: NotNullIfNotNull("parameter1")]
        public Named? Method2((Named? named, string)? parameter1, (Named named, string) parameter2, Named? p3)
        {
            throw new System.NotImplementedException();
        }

        public (Named named, string)? Method2((Named named, string) parameter)
        {
            var method2 = Method2((new Named(), ""), (new Named(), ""), new Named());
            var method2A = method2.A;

            return null;
        }
    }

    internal interface INullableTest2
    {
        (string s/*caret*/, int? t) Property { get; }
    }

    class NullableTest2 : INullableTest2
    {
        public (string s, int? t) Property { get; }

        public NullableTest2((string s, int? t) field)
        {
            Property = field;
        }
    }
}