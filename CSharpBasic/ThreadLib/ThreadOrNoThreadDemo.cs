using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo.Func
{
    /// <summary>
    /// 测试多线程和单线程的区别
    /// </summary>
    public class ThreadOrNoThreadDemo
    {
        public void Test() {
            int[] array = new int[1000000];
            for (int i = 0; i < 1000000; i++)
            {
                array[i] = i;
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            PrintNum(0, 1000000);
            PrintNumDesc(0, 1000000);
            Console.WriteLine("打印结束，耗时：" + sw.ElapsedMilliseconds);
            sw.Stop();
            sw.Restart();
            Console.WriteLine("多线程打印开始，耗时：" + sw.ElapsedMilliseconds);
            Thread t1 = new Thread(() => { PrintNum(0, 1000000); });
            Thread t2 = new Thread(() =>
            {
                PrintNumDesc(0, 1000000);
            });
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("多线程打印结束，耗时：" + sw.ElapsedMilliseconds);
            Console.ReadKey();
            sw.Stop();
        }

        public static void PrintNum(int start, int end)
        {
            List<string> list = new List<string>();
            for (int j = start; j < end; j++)
            {
                list.Add("添加进值=" + j.ToString());
            }
        }

        public static void PrintNumDesc(int start, int end)
        {
            List<string> list = new List<string>();
            for (int j = end - 1; j <= start; j--)
            {
                list.Add("添加进值=" + j.ToString());
            }
        }
    }
}
