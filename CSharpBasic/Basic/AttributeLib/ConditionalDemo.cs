using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic.AttributeLib
{
    public class ConditionalDemo: BaseDemo
    {
        /*
         * 1.什么情况下使用该标识符?
           当程序中一个方法或属性不想再使用时,如果把它删掉就需要把引用的地方一个一个全部删掉不然就会编译错误,这时我们就可以在塔的上面加一[Conditional("string")] 然后程序运行时就会忽略它
           ps:[Conditional("string")]里面字符串随意取  
           2.如果想再次调用那个方法或属性怎么办?
           这个很简单,你只需在引用命名空间那个地方进行一个宏定义把你在[Conditional("string")]里面的字符串定义出来就能用了
         * */
        
        [Conditional("DEBUG")]
        public static void Message_Conditional(string msg)
        {
            //现在的话如果想再次调用第一个方法就需要一个宏定义,注意这个宏定义需要放在system之前,否则会出现错误
            Console.WriteLine(msg);
        }

        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }

        public override void DoTest()
        {
            Message("Message.");
            Message_Conditional("Message_Conditional.");
            Console.ReadKey();
        }
    }
}
