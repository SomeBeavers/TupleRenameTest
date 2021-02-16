using System;

namespace TupleRenameTest
{
    public class Parameter1
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        private (string s, T T1) _parameterT;

        private void Test1(out (string s, int t) par)
        {
            //Console.WriteLine(par.s);
            //Console.WriteLine(par.t);
            par = (null, 0);
            Console.WriteLine(par.s);
            Console.WriteLine(par.ToTuple().ToValueTuple().Item1);
        }

        private void UseTest1()
        {
            (string s, int t) par;
            Test1(out par);
            par.s = "";
        }

        public void Test2(in (string s, int t) par)
        {
            while (par.t>0) 
            {
                var valueTuple = par;
                valueTuple.t--; 
                //par.t_1--;
            }
        }

        public void UseTest2()
        {
            new Parameter1().Test2(par:(s: "", t: 1));
        }

        public void Test3(params (string s1, T par1_12)[] par)
        {
            foreach (var parameter in par)
            {
                {
                    using var t = parameter.par1_12;
                    Console.WriteLine(parameter.s1);
                    if (false)
                    {
                        Console.WriteLine(parameter.par1_12);
                    }
                    else
                    {
                        _parameterT = parameter;
                        Console.WriteLine(_parameterT.T1);
                        var parameter1 = parameter;
                        Console.WriteLine(parameter1.par1_12);
                    }

                    while (Boolean.Parse(parameter.par1_12.ToString()))
                    {
                        Console.WriteLine($"{parameter.par1_12} = parameter.T");
                    }


                    NewFunction();

                    #region Many usages

                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }
                    for (int i = 0; i < par.Length; i++)
                    {
                        Console.WriteLine($"{par[i].par1_12} = parameter.T");
                    }

                    #endregion

                    do
                    {
                        Console.WriteLine($"{parameter.par1_12} = parameter.T");
                    } while (true);


                    Console.WriteLine($"{parameter.par1_12} = parameter.T");
                }

                void NewFunction()
                {
                    Console.WriteLine($"{parameter.par1_12} = parameter.T");
                }
            }
        }
    }

    public class T:IDisposable
    {
        public void Test21_UseField()
        {
            var s = new UseField2().FieldWithManyUsages1.s121;
        }
        public void Dispose()
        {
        }
    }
}