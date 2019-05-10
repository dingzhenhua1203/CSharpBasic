using AttributeDemo.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo.Model
{
    [DzhTest(name:"DZH",verison:"1.0.0.0", Describtion ="测试")]
    public class Student
    {
        public int ID;

        public string Name;

        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                    age = 18;
                else
                    age = value;
            }
        }

        public string Sex { get; set; }

        public override string ToString()
        {
            return "学号：" + ID + "  姓名：" + Name + "  年龄：" + age + "  性别：" + Sex;
        }
    }
}
