using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic
{
    /// <summary>
    /// 测试string是值传递还是地址传递
    /// </summary>
    public class StringTest
    {
        public static void TestDemo()
        {
            Console.ReadLine();
            
            string test = "hello";

            Console.WriteLine("调用前test=" + test);//hello
            TestString(test);
            Console.WriteLine("调用后test=" + test);//hello
            Console.ReadKey();
        }

        /// <summary>
        /// 测试string是值传递还是地址传递
        /// </summary>
        /// <param name="temp"></param>
        public static void TestString(string temp)
        {
            temp = "changed";
            Console.WriteLine("调用中temp=" + temp);
        }
    }
}
