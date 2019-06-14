using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic
{
    public class CollectionsDemo
    {
        public static void Collect()
        {
            //集合
            ArrayList al = new ArrayList();
            al.Add("dzh");
            al.Add(1);


            Hashtable ht = new Hashtable();
            ht.Add("lf", "路飞");
            //ht.Add("lf", "娜美");//key值不能重复
            ht.Add("nm", "娜美");
            ht.Add("qb", "乔巴");
            foreach (var i in ht.Values)
            {
                Console.WriteLine(i);//方法1.遍历hashtable的value值
            }
            foreach (DictionaryEntry i in ht)
            {
                Console.WriteLine(i.Value);//方法2.遍历hashtable的value值
            }
            //hashtable不能通过for循环访问。没有下标索引

            //泛型集合
            List<string> li = new List<string>();
            li.Add("luffy");

            Dictionary<string, string> di = new Dictionary<string, string>();
            di.Add("luff", "路飞");
            di.Add("nm", "娜美");
            di.Add("qb", "乔巴");
            foreach (string s in di.Keys)
            {
                Console.WriteLine(s);//方法1.遍历value值
            }
            foreach (KeyValuePair<string, string> kv in di)
            {
                Console.WriteLine("===================小区别，KeyValuePair=====================");
                Console.WriteLine(kv.Value);//方法2.遍历value值
            }
        }
    }
}
