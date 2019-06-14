using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo.Func
{
    /// <summary>
    /// 测试前台线程和后台线程区别
    /// </summary>
    public class IsBackgroundThreadDiffDemo
    {
        public void Test()
        {

            Console.WriteLine("主线程Id：" + Thread.CurrentThread.ManagedThreadId);
            Thread t1 = new Thread(() => { Console.WriteLine("线程Id：" + Thread.CurrentThread.ManagedThreadId); Thread.Sleep(3000); });
            Console.WriteLine("T1线程Id：" + t1.ManagedThreadId);
            t1.IsBackground = true;
            t1.Start();
            t1.Join(); //告诉主线程等待t1执行完才继续执行

            Console.WriteLine("主线程执行完毕");
        }
    }
}
