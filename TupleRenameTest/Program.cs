using System;

(string s, int t) A()
{
    return (null, 0);
}

var localVar = A();
var localVar2 = A();
var localVarS = (localVar.s, localVar2.t);
var i = localVarS.t;
Console.WriteLine("Hello World!");