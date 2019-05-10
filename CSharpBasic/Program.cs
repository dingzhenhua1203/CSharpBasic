using CSharpBasic.Func;
using CSharpBasic.Func.ForeachDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("...........................【TryCatchFinallyDemo验证】...........................");
            //TryCatchFinallyDemo.TestDemo(1);
            //Console.ReadKey();

            //Console.WriteLine("...........................【Random验证】...........................");
            //RandomDemo.TestDemo();

            //#region 测试&
            ////var it1 = 0 & 0;
            ////var it2 = 0 & 1;
            ////var it3 = 3 & 0;
            ////var it4 = 1 & 3;
            ////Console.WriteLine("it1=" + it1 + " it2=" + it2 + " it3=" + it3 + " it4=" + it4);
            //int i = 6, j = 8;
            //Console.WriteLine("i&j=" + (i & j));
            ////Console.WriteLine("i&&j=" + (i && j));
            //#endregion

            //Console.WriteLine("...........................【null?.Id验证】...........................");
            //NullCheck.CheckNull();

            //Console.WriteLine("...........................【DateTime调试】...........................");
            //DateTimeDemo.TestDemo();

            //Console.WriteLine("...........................【测试string是值传递还是地址传递】...........................");
            //StringTest.TestDemo();

            //Console.WriteLine("...........................【结论null==和==null没有任何区别】...........................");
            //NullJudgeDemo.TestDemo();

            Console.WriteLine("...........................【实现IEnumerable，使用foreach】...........................");
            ForeachDemo.TestDemo();
        }




    }  
}
