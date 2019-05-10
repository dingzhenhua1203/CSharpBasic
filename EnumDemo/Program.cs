using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //获取枚举字符串
            Sex time = Sex.Man;

            #region 枚举转化
            string strA = "Man";
            Sex myEnum = (Sex)Enum.Parse(typeof(Sex), strA);//字符串转换为枚举

            int i = Convert.ToInt32(Sex.Man); //获取枚举的值

            Sex sex = (Sex)i;//整数转换为枚举值
            #endregion
            
            Console.WriteLine(time.ToString());//输出：Man
            Console.WriteLine("-------------------------------");
            //Enum.Parse()方法。
            Sex time2 = (Sex)Enum.Parse(typeof(Sex), "Man", true);
            Console.WriteLine((int)time2);//输出：1
            Console.WriteLine("-------------------------------");

            #region 得到枚举的某一值对应的名称
            //两种方法都能实现，但是当其值越界（不是枚举所列出的值），就有一定的区别了。大家可以根据自己的需求不同，选择合适的方法。
            Console.WriteLine(((Sex)1).ToString()); //输出：Man，如果越界返回原值
            Console.WriteLine(Enum.GetName(typeof(Sex), 1)); //输出：Man，如果越界返回空字符串
            #endregion
            Console.WriteLine("-------------------------------");
            //枚举所有的名称 
            foreach (string temp in Enum.GetNames(typeof(Sex)))
                Console.WriteLine(temp.ToString()); //Man Women Seek
            //得到枚举的所有的值 
            foreach (var item in Enum.GetValues(typeof(Sex)))
                Console.WriteLine(item.ToString()); //Man Women Seek
            Console.WriteLine("-------------------------------");
            //Sex.Man.
            Console.ReadKey();
        }
    }

    public enum Sex
    {

        [Description("男")]
        Man = 1,
        [Description("女")]
        Women = 2,
        [Description("中")]
        Seek = 3

    }
}
