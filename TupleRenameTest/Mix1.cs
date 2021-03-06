﻿using System;
using System.Diagnostics;
using System.Linq;
using TupleRenameTest;
using MyAlias = System.Collections.Generic.List<System.Tuple<int, string, int>>;
using MyAlias1 = System.Collections.Generic.List<(int t, string s)>;

namespace ConsoleApp5
{
    internal class Program1
    {
        private VeryCurrent VeryCurrent1 { get; set; }

        public (string s, int t) Current => VeryCurrent1.KeyValue;

        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }

        private static void Main1(string[] args)
        {
            MyAlias x;
            x = new MyAlias();

            // TODO: no rename
            var item1 = x.First().Item1;
            Console.WriteLine("Hello World!");
        }

        private static void Main2(string[] args)
        {
            MyAlias1 x;
            x = new MyAlias1();

            var item1 = x.First().t;
            Console.WriteLine("Hello World!");
        }

        public class VeryCurrent
        {
            public (string s, int t) KeyValue { get; internal set; }
        }
    }

    internal class Enum<A>
    {
        public (bool Success, A Value) Get(int index)
        {
            return (false, default);
        }
    }

    internal class SeqLazy<A>
    {
        private readonly Enum<A> seq;

        private (bool Success, A Value) Test(int index)
        {
            while (seq != null && seq.Get(1).Success)
            {
            }

            return (false, default);
        }
    }




}