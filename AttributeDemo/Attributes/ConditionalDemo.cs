using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo.Attributes
{
    public class ConditionalDemo
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    public class Test
    {
        static void function1()
        {
            ConditionalDemo.Message("In Function 1.");
            function2();
        }
        static void function2()
        {
            ConditionalDemo.Message("In Function 2.");
        }
        public static void Do()
        {
            ConditionalDemo.Message("In Main function.");
            function1();
            Console.ReadKey();
        }
    }
}
