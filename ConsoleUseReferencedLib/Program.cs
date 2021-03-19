using System;
using System.Collections.Generic;
using MultiReferencedLib;

namespace ConsoleUseReferencedLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var item4Tlist = new NugetLib.NugetLib().NugetLibMethod<A>().Item4.Tlist;
            (A, A t, string s, (List<A> Tlist1, int count)) nugetLibMethod = new NugetLib.NugetLib().NugetLibMethod<A>();
            nugetLibMethod.Item4.Tlist1.Add(new A());


            var hasUrl = new MultiReferencedLib1().Test1("").b12;
            Console.WriteLine(new MultiReferencedLib1().Property.s121_renamed);
            Console.WriteLine(new MultiReferencedLib1().Property.t1);
            Console.WriteLine("Hello World!");
        }
    }

    internal class A
    {
    }
}
