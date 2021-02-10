using System.Linq;

class O
{
    public C Foo(object c)
    {
        (C c_renamed, C c1) p = default((C, C));
        return p.c_renamed;
    }
}

class C {
    int Foo(bool condition)
    {
        int a;
        var t = condition
            ? Bar(true, out a)
            : Bar(false, out a);

        return t + a;
    }

    int Bar(bool condition, out int value)
    {
        value = 42;
        return condition ? 1 : 2;
    }
}