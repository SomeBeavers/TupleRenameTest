﻿using System;
using MultiReferencedLib;

namespace UseMulti2
{
    class Program
    {
        static void Main(string[] args)
        {
            var valueTuple = new MultiReferencedLib1().Property;
            Console.WriteLine(valueTuple.coolName);
            Console.WriteLine(valueTuple.Item2);
            Console.WriteLine("Hello World!");
        }
    }
}
