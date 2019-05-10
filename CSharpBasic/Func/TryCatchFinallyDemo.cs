using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Func
{
    public class TryCatchFinallyDemo
    {
        public static void TestDemo(int counter) {
            if (counter > 3)
            {
                Console.WriteLine("超过3次，结束");
                return ;
            }
            try
            {
                Console.WriteLine("try"+counter);
                counter = counter + 1;
                 TestDemo(counter);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex:" + ex.ToString());
                return ;
            }
            finally {
                counter = counter + 1;
                Console.WriteLine("finally" + counter);
            }
        }
    }
}
