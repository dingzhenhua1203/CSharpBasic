using CSharpBasic.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasic.ThreadLib
{
    public class ThreadDemo : BaseDemo
    {
        public override void DoTest()

        {
            /*
            * Q: CPU如果是单核的，多个线程为什么效率还提高了？
            * A:CPU要处理很多线程的任务，将一个程序分配多个线程，则被CPU执行的概率应该就更高了
            */

            #region 线程入门
            //ParameterizedThreadStart 
            ThreadStart ts = () => { Console.WriteLine("我是线程1"); Thread.Sleep(5000); Console.WriteLine("我还是线程1"); };
            Thread thread1 = new Thread(ts);
            Thread thread2 = new Thread(Test);
            //线程默认为前台线程，值为false
            //一个进程退出的标志：所有前台线程都执行完后才会退出
            thread2.IsBackground = true;
            //告诉操作系统，准备好了
            thread1.Start();
            thread2.Start();

            //执行thread2.Join()代码的线程（这里即主线程），等待thread2线程执行完才执行
            thread2.Join(1000); //参数可选：指定，则表示最多等待多少ms

            //thread2.Abort();//不得已才使用。线程正常退出是相应的方法体执行完
            //主线程的while循环
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("主线程...");
                Thread.Sleep(100);
            }
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);//当前线程的ID,即主线程

            //当线程IsBackground为true,需要Console.ReadLine(),才能确保线程执行的方法中的控制台不会一闪而过
            //IsBackground为false则，主线程（main，也是前台线程）就会等待前台线程执行完,所有Console.ReadLine()可以不写
            //Console.ReadLine来控制主线程main不自动结束，这样就能看到控制台
            Console.ReadLine();
            #endregion 

            bool[] IsCallSuccessFlag = new bool[3] { false, false, false };

            //引入多线程分段处理
            Thread t1 = new Thread(() =>
            {
                if (!PrintNum(1))
                    Console.WriteLine("线程1失败,ID=" + Thread.CurrentThread.ManagedThreadId);
                IsCallSuccessFlag[0] = true;
            });
            Thread t2 = new Thread(() =>
            {
                if (!PrintNum(2))
                {
                    Console.WriteLine("线程2失败................ID=" + Thread.CurrentThread.ManagedThreadId);
                    IsCallSuccessFlag[1] = false;
                }
            });
            Thread t3 = new Thread(() =>
            {
                if (!PrintNum(3))
                    Console.WriteLine("线程3失败,ID=" + Thread.CurrentThread.ManagedThreadId);
                IsCallSuccessFlag[2] = true;
            });
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine("IsCallSuccessFlag[3]=" + IsCallSuccessFlag[0] + "," + IsCallSuccessFlag[1] + "," + IsCallSuccessFlag[2]);
            if (IsCallSuccessFlag[0] && IsCallSuccessFlag[1] && IsCallSuccessFlag[2])
                Console.WriteLine("我是主线程，我的ID=" + Thread.CurrentThread.Name + "成功啦，结束");
            else
                Console.WriteLine("我是主线程，我的ID=" + Thread.CurrentThread.ManagedThreadId + "失败啦，结束");
            Console.ReadLine();
        }

        public static bool PrintNum(int i)
        {
            List<string> list = new List<string>();
            for (int j = 1; j <= 100; j++)
            {
                list.Add("第" + i + "线程，循环添加进值=" + j.ToString());
            }
            foreach (var item in list)
                Console.WriteLine("线程Id=" + Thread.CurrentThread.ManagedThreadId + "...List值..." + item);
            return false;
        }

        public static void Test()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("线程..." + DateTime.Now.ToString());
                Thread.Sleep(100);
            }
        }
    }
}
