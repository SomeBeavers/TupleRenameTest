﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TupleRenameTest
{
    //public class Field1
    //{
    //    public (string s_1, int t) field1;
    //}

    //class UseField1
    //{
    //    public Field1 Test1()
    //    {
    //        var field1 = new Field1();

    //        #region MyRegion

    //        var field1S = (field1.field1.s_1);

    //        #endregion

    //        return field1;
    //    }
    //}
    // ReSharper disable once UnusedType.Global
    class UseField2
    {
        //private string _field1SRenamed;

        //public async Task Test1()
        //{
        //    var field1SRenamed = new UseField1().Test1().field1.s_1;
        //    if (field1SRenamed != null)
        //    {
        //        _field1SRenamed = field1SRenamed;
        //    }

        //    var tuple = await GetTupleAsync(null).ConfigureAwait(false);
        //    var tupleS = tuple.s1;
        //}

        // ReSharper disable once UnusedMember.Local
        private async Task<(string s1, int t)> GetTupleAsync(List<(string s/*caret*/, int t)> p)
        {
            (string s, int t) valueTuple = (p.First().s, 1);
            return (p.FirstOrDefault().s, p.Count);
        }
    }
}