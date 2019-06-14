using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasic.ThreadLib
{
    public class TaskDemo : BaseDemo
    {
        public override void DoTest()
        {
            #region 注释说明
            /*
            1.使用构造函数创建Task

            Task t1 = new Task(MyMethod);
            2.使用Task.Factory.StartNew 进行创建Task

            Task t1 = Task.Factory.StartNew(MyMethod);
             * */
            #endregion

            Task t1 = new Task(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(DateTime.Now.ToString());
                    Thread.Sleep(1000);
                }
            });
            t1.Start();
            Console.WriteLine("主线程代码运行结束");
            Console.ReadLine();

            #region Task线程
            Task tk1 = Task.Factory.StartNew(() =>
            {
                List<int> list = new List<int>();
                for (int i = 0; i <= 100; i++)
                {
                    list.Add(i);
                }
                Console.WriteLine("线程ID=" + Thread.CurrentThread.ManagedThreadId + "执行的List数量为：" + list.Count);

            });
            Task tk2 = Task.Factory.StartNew(() =>
            {
                List<int> list = new List<int>();
                for (int i = 0; i <= 1000000; i++)
                {
                    list.Add(i);
                }
                Console.WriteLine("线程ID=" + Thread.CurrentThread.ManagedThreadId + "执行的List数量为：" + list.Count);

            });
            tk1.Wait(); tk2.Wait();
            Console.WriteLine("我是主线程，我的ID=" + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("---------------------------------------------------------------");

            #region 引入Task线程分段处理

            List<int> listA = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                listA.Add(i);
            }
            //定义区间频率
            int startPage = 1;
            int endPage = 16;
            int rate = (endPage - startPage + 1) / 4;
            int GroupCount = 4; //定义分区数量
            int[] begin = new int[4];
            int[] end = new int[4];
            ConcurrentBag<bool> BagRtnValue = new ConcurrentBag<bool>(); //记录每个线程执行的返回结果
            for (int k = 0; k < GroupCount; k++)
            {
                //定义好每个区间起始
                begin[k] = startPage + rate * k;
                end[k] = begin[k] + rate - 1;
                if (k == GroupCount - 1)
                    end[k] = endPage;
            }
            List<Task> taskList = new List<Task>();
            for (int index = 0; index < 4; index++)
            {
                int tempIndex = index; //快照
                taskList.Add(Task.Factory.StartNew(() =>
                {
                    for (int j = begin[tempIndex]; j <= end[tempIndex]; j++)
                    {
                        if (listA[j] == 6)
                        {
                            Console.WriteLine("return 掉了" + listA[j]);
                            return;//线程内return 只结束当前线程不影响其他线程和主线程
                        }
                        Console.WriteLine("for线程ID=" + Thread.CurrentThread.ManagedThreadId + "执行的List：" + listA[j]);
                    }
                }));

            }
            Task.WaitAll(taskList.ToArray()); //主线程等待并发处理完毕
            # endregion

            Console.ReadLine();
            #endregion
        }
    }
}
