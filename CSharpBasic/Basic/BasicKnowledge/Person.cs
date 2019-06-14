using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic.BasicKnowledge
{
    public abstract class Person
    {
        private int age;
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            set
            {
                if (value < 18)
                    age = 0;
                else
                    age = value;
            }
            get
            {
                return age;
            }
        }

        public string Address
        {
            get;
            set;
        }

        public abstract string Sex//抽象属性
        {
            get;//这里就是没有实现，不加abstract则net会帮忙生成省略的代码。加了就是抽象的，net不生成，由子类实现
            set;
        }

        public string this[int index]//索引器
        {
            get
            {
                string value = null;
                switch (index)
                {
                    //C#不同于Java,C#中case后都必须有break动作，否则报错，Java中则不管
                    case 0: value = this.Name; break;
                    case 1: value = this.Age.ToString(); break;
                    case 2: value = this.Address; break;
                    default: value = this.age.ToString(); break;
                }
                return value;
            }
        }

        public virtual void DoAction()//虚方法，不是一定要在抽象类中的！
        {
        }

        //抽象方法必须在抽象类中，故类也要被abstract修饰。
        //抽象类中可以有实例方法，也可以没有抽象方法。这样做仅仅是为了不让类被实例化（即不让new对象）。
        //抽象方法不能有任何实现
        //与虚方法不同，抽象方法必须被重写，除非子类也是抽象类
        public abstract void DoAction1();
    }
}
