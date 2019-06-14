using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasic.ThreadLib
{
    public class ThreadPoolDemo : BaseDemo
    {
        public override void DoTest()
        {
            Console.WriteLine("主线程Id：" + Thread.CurrentThread.ManagedThreadId);
            //WaitCallback是一个有参无返回值的委托。
            //WaitCallback函数原型：public delegate void WaitCallback(Object state);
            //ThreadPool.QueueUserWorkItem(new WaitCallback(Print));
            // ThreadPool.QueueUserWorkItem((o) => { Console.WriteLine("Lambda表达式执行,Id：" + Thread.CurrentThread.ManagedThreadId); });

            for (int i = 0; i < 4; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Print), i);
            }
            Console.ReadKey();
        }
        public static void Print(object o)
        {
            int Seed = (int)o;
            int start = 1 + Seed * 10;
            Console.WriteLine("线程Id" + Thread.CurrentThread.ManagedThreadId + "打印：" + Seed);
            for (int i = start; i < start + 10; i++)
            {
                Console.WriteLine("循环,线程Id" + Thread.CurrentThread.ManagedThreadId + "打印：" + i);
            }
        }
    }
}
