using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Func.BasicKnowledge
{
    public class Demo
    {
        public static void TestDemo() {
            /*
            //属性和索引器
            Person p1 = new Person();
            Person p2 = new Person();
            p1.Name = "zhangsan";
            p1.Address = "suzhou";
            p1.Age = 16;
            p2.Name = "lisi";
            p2.Address = "shanghai";
            p2.Age = 20;
            Console.WriteLine(p1.Age.ToString() + "...." + p2.Age.ToString());
            Console.WriteLine("p1的年龄是{0}....p2的年龄是{1}", p1.Age.ToString(), p2.Age.ToString());//占位符方式
            Console.WriteLine(p1[0] + "...." + p1[1] + "...." + p1[2] + "...." + p1[3]);
            Console.ReadKey();
             * */

            /*
            //里氏替换原则，父类对象赋值子类对象
            Person[] p = { new Employee(), new Student() };
            for (int i = 0; i < p.Length; i++)
            {
                p[i].DoAction(); //利用虚方法实现重写（实现多态的一种方法）
            }
            */

            Dog dog1 = new Dog();
            dog1.Eat();
            dog1.Sleep();
            IAnimal ani = new Dog();
            ani.Eat();//同样可以打印出DOG Eat
        }
    }
}
