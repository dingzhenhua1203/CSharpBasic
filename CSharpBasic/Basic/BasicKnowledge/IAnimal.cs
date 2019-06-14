using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic.BasicKnowledge
{
    public interface IAnimal//若实现多个接口，用","隔开
    {
        //接口里只能包含方法(属性，事件，索引器也是方法)，抽象类可以定义字段、属性、包含有实现的方法
        //接口中的成员不能有访问修饰符，默认即为Public
        //接口不能被实例化
        void Eat();
        void Sleep();
    }
}
