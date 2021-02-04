using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTuple<int, int> tuple = ValueTuple.Create(1,2);
            Console.WriteLine(tuple.Item1 + tuple.Item2);
        }
    }
}
