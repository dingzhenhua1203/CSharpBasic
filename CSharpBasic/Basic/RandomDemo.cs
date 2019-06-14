using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic
{
    public class RandomDemo
    {
        public static void TestDemo()
        {
            //随机种子
            //var seed = Guid.NewGuid().GetHashCode();
            //Random random = new Random(seed);
            Random random = new Random();
            for (int t= 0; t < 1000; t++)
            {
                var i = random.Next(4);
                if (i == 10) {
                    Console.WriteLine("..............................");
                }

                Console.WriteLine(i); 
            }

            //Console.WriteLine(".............【Random随机性】.................");
            //for (int t = 0; t < 100; t++)
            //{
            //    Random rand = new Random();
            //    var i = rand.Next(10);//随机性不强
            //    if (i == 10)
            //    {
            //        Console.WriteLine("..............................");
            //    }

            //    //Console.WriteLine(i);
            //}
            Console.ReadKey();
        }

    }
}
