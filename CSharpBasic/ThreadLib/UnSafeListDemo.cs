using CSharpBasic.Basic;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.ThreadLib
{
    public class UnSafeListDemo : BaseDemo
    {
        public override void DoTest()
        {
            List<int> list = new List<int>();

            #region 测试List不安全
            List<Task> taskList = new List<Task>();
            for (int index = 0; index < 400; index++)
            {
                taskList.Add(Task.Factory.StartNew(() =>
                {
                    List<int> temp = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                    list.AddRange(temp);
                }));

            }
            Task.WaitAll(taskList.ToArray()); //主线程等待并发处理完毕
            #endregion

            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            #region 改进方法
            taskList = new List<Task>();
            for (int index = 0; index < 400; index++)
            {
                taskList.Add(Task.Factory.StartNew(() =>
                {
                    List<int> temp = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
                    foreach (var element in temp)
                    {
                        bag.Add(element);
                    }
                }));

            }
            Task.WaitAll(taskList.ToArray()); //主线程等待并发处理完毕
            #endregion

            Console.Write("不安全的：" + list.Count() + "...安全的：" + bag.Count);
            Console.ReadKey();
        }
    }
}
