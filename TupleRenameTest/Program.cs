using System;

(string s, int t) A()
{
    return (null, 0);
}

var local1 = ("", SomeString: "", "");
var c = local1.SomeString[1];

(string s, int t) A2()
{
    var c = local1.SomeString[1];
    return (null, 0);
}
var c1 = local1.SomeString[1];

if (Boolean.Parse(local1.SomeString))
{
 Console.WriteLine($@"{local1.SomeString
                       +local1.SomeString}");   
}

var localVar = A();
var localVar2 = A();
var localVarS = (s: localVar.s, t1: localVar2.t);
var i = localVarS.t1;
Console.WriteLine("Hello World!");