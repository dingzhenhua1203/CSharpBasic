using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic.ForeachLib
{
    /// <summary>
    /// 实现IEnumerable，使用foreach
    /// </summary>
    public class ForeachDemo
    {
        public static void TestDemo()
        {
            int[] count = new int[] { 1, 2, 3, 4 };
            BookNames p = new BookNames();
            p.Name = new string[] { "luffy", "Nami", "chorper", "zoro" };
            /*
            for (int i = 0; i < p.Name.Length; i++)
                Console.WriteLine(p.Name[i]);
            Console.ReadKey();
             */
            foreach (var c in count)
            {
                Console.WriteLine("次数：" + c);
                foreach (string item in p.Name)
                {
                    if (item == "Nami")
                    {
                        break;
                    }
                    Console.WriteLine(item);
                }

            }
            Console.ReadKey();
        }
    }
}
