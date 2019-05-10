using CSharpBasic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Func
{
    /// <summary>
    /// 结论null==和==null没有任何区别
    /// </summary>
    public class NullJudgeDemo
    {
        public static void TestDemo()
        {

            #region 结论null==和==null没有任何区别

            List<Person> plist = new List<Person>();
            plist.Add(null);
            var item = plist.First();
            //bool f1 = null == item.Id;
            //Console.WriteLine("" + item.Id);
            //Console.WriteLine(""+f1.ToString());

            Person p1 = null;

            //Console.WriteLine("" + p1.Id);
            Console.WriteLine("" + (null == p1.Name));
            Console.WriteLine("" + ((p1.Name == null) ? "hhh" : p1.Name));
            //Console.WriteLine("" + p1.Name.ToString());
            Console.Read();
            #endregion
        }
    }
}
