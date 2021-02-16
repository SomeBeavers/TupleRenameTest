using System.Collections.Immutable;

namespace TupleRenameTest
{
    public abstract record Record1((string Name, int T) TupleInRecord)
    {
        protected (int t, string s) Name;
        public virtual (Record2 r2, Record1 r1, Record4 r4) VirtualMethod()
        {
            return (null, null, null);
        }
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
    }

    record Record3 : Record1
    {

        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        public Record3((string Name, int T) TupleInRecord) : base(TupleInRecord)
        {
            var s = Name.s;
        }

        public override (Record2 r2, Record1 r1, Record4 r4) VirtualMethod()
        {
            return base.VirtualMethod();
        }

        public override string ToString()
        {
            // TODO: rename on usage here
            return base.ToString() + (this.TupleInRecord.Name, 1).Name.ToString();
        }
    }

    public record Record2((string Name, int T) TupleInRecord) : Record1(TupleInRecord)
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
    }

    public record Record4: Record1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        public new (string Name, int T) TupleInRecord { get; set; }

        public Record4((string Name, int T) TupleInRecord) : base(TupleInRecord)
        {
            this.TupleInRecord = TupleInRecord;
        }
    }

    record Record5((string Name, int T) TupleInRecord, (string Name, int Item2) AnotherProp) : Record1(TupleInRecord)
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        public new (string Name, int T) TupleInRecord { get; set; }
    }

    class UseRec2
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        private void Test2()
        {
            var record5 = new Record5(("", 2), ("", 2));
            var name = record5.TupleInRecord.Name;
            var item1 = record5.TupleInRecord.Item1;
            var name2 = record5.AnotherProp.Name;
            var item2 = record5.AnotherProp.Item2;

            var virtualMethod = new Record3(("", 1)).VirtualMethod();
            virtualMethod.r4 = new Record4(("", 1));
        }
    }

    class Class1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        public Class1((string Name, int T) tupleInClass)
        {
            TupleInClass = tupleInClass;
        }

        public (string Name, int T) TupleInClass { get; set; }
    }

    class UseClass1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        private void Test3()
        {

        }
    }

    record UseRec
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        public void Test1()
        {
            //new Record1((Name: "", T: 1)).TupleInRecord.Name.ToImmutableList();
            new Record2((Name: "", T: 1)).TupleInRecord.Name.ToImmutableList();
            new Record3((Name: "", T: 1)).TupleInRecord.Name.ToImmutableList();
            new Record4((Name: "", T: 1)).TupleInRecord.Name.ToImmutableList();
        }
    }
}