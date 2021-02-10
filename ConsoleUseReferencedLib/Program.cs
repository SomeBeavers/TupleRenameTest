using System;
using MultiReferencedLib;

namespace ConsoleUseReferencedLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var hasUrl = new MultiReferencedLib1().Test1("").b;
            Console.WriteLine("Hello World!");
        }
    }
}
