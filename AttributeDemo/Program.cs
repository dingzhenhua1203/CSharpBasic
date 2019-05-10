using AttributeDemo.Attributes;
using AttributeDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test.Do();
            Student stu1 = new Student() { ID=1,Name="Luffy",Age=20,Sex="男"};
            Student stu2 = new Student() { ID = 1, Name = "Nami", Age = -1,Sex = "女" };
            Console.WriteLine(stu1.ToString());
            Console.WriteLine(stu2.ToString());
            System.Reflection.MemberInfo info = typeof(Student);
            object[] attributes = info.GetCustomAttributes(true);//特性名称
            var classAttribute = (DzhTestAttribute)Attribute.GetCustomAttribute(info, typeof(DzhTestAttribute));
            Console.WriteLine(classAttribute.Name);
            Console.WriteLine(classAttribute.Date);
            Console.WriteLine(classAttribute.Describtion);
            for (int i = 0; i < attributes.Length; i++)
            {
                System.Console.WriteLine(attributes[i]);
            }
            Console.ReadKey();
        }
    }
}
