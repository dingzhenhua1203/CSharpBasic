using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    //继承的时候 类必须写在接口前面
    //类只能继承一个类，可以是抽象类 也可以是实类，可以是继承了实类的抽象类，接口可以多个
    public abstract class Car :  MachineB, ICar  
    {
        //抽象类继承接口，可以不实现接口中的方法，但必须显示声明出来
        //抽象类可以没有任何东西，可以有抽象方法或非抽象方法，可以没有抽象方法，仅仅是为了不让实例化
        //抽象方法必须再抽象类中

        public abstract void Drive(string name);


        public abstract bool AddOil(string name, int money);

        public abstract bool OpenLight(string name);
    }

    public abstract class SportCar : Car
    {
        //抽象类继承抽象类，可以不实现接口中的方法，也不需要显示声明出来
        //抽象类可以继承实体类
    }


    //public abstract class LittlerCar : BigCar
    //{
    //    //抽象类可以继承实体类
    //}

    //public class BigCar : Car
    //{
    //    public override bool AddOil(string name, int money)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void Drive(string name)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override bool OpenLight(string name)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public abstract class BussinessCar
    {
        //抽象方法必须在抽象类中
        public abstract void Eat();
    }

    public abstract class Machine: MachineA
    {
        public abstract void Eat();
    }

    public  class MachineA
    {
        public void EatA() { }
    }

    public class MachineB
    {
        public void EatB() { }
    }
}
