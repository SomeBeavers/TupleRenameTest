using System;

namespace TupleRenameTest
{
    public class Deconstruct
    {


        private void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s;
        }
        private void Test1(string s)
        {
            (string destination, double distance) t = (destination: "post office", distance: 3.6);
            var tDestination = t.destination;

            (string destination, double distance) = t;

            Console.WriteLine($"Distance to {destination} is {distance} kilometers.");
        }
        private void Test2()
        {
            Test1(s: "");
            (string destination, double distance) t = (destination: "post office", distance: 3.6);
            (var destination, var distance) = t;

            Console.WriteLine($"Distance to {destination} is {distance} kilometers.");
        }
        private void Test3()
        {
            (string destination, double distance) t = (destination: "post office", distance: 3.6);
            var (destination, distance) = t;

            Console.WriteLine($"Distance to {destination} is {distance} kilometers.");
        }
        private void Test4()
        {
            var destination = string.Empty;
            var distance = 0.0;

            (string destination, double distance) t = (destination: "post office", distance: 3.6);

            (destination, distance) = t;
            Console.WriteLine($"Distance to {destination} is {distance} kilometers.");
        }

        (int myTest, int B) GetPoint()
        {
            var myTest = 1;
            return (myTest, 2);
        }
    }
}