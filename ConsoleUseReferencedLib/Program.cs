using System;
using MultiReferencedLib;

namespace ConsoleUseReferencedLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var hasUrl = new MultiReferencedLib1().Test1("").b1;
            Console.WriteLine(new MultiReferencedLib1().Property.s121);
            Console.WriteLine(new MultiReferencedLib1().Property.t1);
            Console.WriteLine("Hello World!");
        }
    }
}
