using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic
{
    public delegate void Mydelegate(string food);

    public class DelegateDemo : BaseDemo
    {
        public override void DoTest()
        {
            //Func只有带泛型的一种形式，Action有带泛型和不带的两种
            //Action 属于无参无返回值的函数类型,
            //Action<T> 通过设置泛型，我们可以定义有多个参数， 无返回值的函数
            //Func 委托必须要带有一个返回值,可以有0个或多达16个参数类型,最后一个泛型参数代表返回类型，前面的都是参数类型
            //总之：Action无返回值 Func有返回值
            Animal an = new Animal();
            an.Eat("pig", eat1); //注意：传递的是方法名eat1
            an.Eat("fruit", eat1);

            //匿名方法方式
            an.Eat("fish", delegate (string food) { Console.WriteLine(food); Console.ReadKey(); });

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
