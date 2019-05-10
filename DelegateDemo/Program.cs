using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void Mydelegate(string food);
    class Program
    {
        static void Main(string[] args)
        {
            Animal an = new Animal();
            an.Eat("pig", eat1); //注意：传递的是方法名eat1
            an.Eat("fruit", eat1);

            //匿名方法方式
            an.Eat("fish", delegate(string food) { Console.WriteLine(food); Console.ReadKey(); });

            //lambda表达式
            an.Eat("dark", (str) => { Console.WriteLine(str); Console.ReadKey(); });

            //使用自行自带的委托类型，不需要声明委托类型了
            Person p = new Person();
            p.Eat("rice", (str) => { Console.WriteLine(str); Console.ReadKey(); });
            Console.WriteLine("===================委托Demo结束==========================");
            Console.ReadKey();
        }
        public static void eat1(string food)
        {
            Console.WriteLine(food);
            Console.ReadKey();
        }
    }

    public class Animal
    {
        public void Eat(string str, Mydelegate eatfood)
        {
            Console.WriteLine("==========================");
            //执行代码
            eatfood("EAT :" + str);
            Console.WriteLine("==========================");
            Console.ReadKey();
        }
    }

    public class Person
    {
        public void Eat(string str, Action<string> eatfood)
        {
            Console.WriteLine("==========================");
            //执行代码
            eatfood("EAT :" + str);
            Console.WriteLine("==========================");
            Console.ReadKey();
        }
    }
}
