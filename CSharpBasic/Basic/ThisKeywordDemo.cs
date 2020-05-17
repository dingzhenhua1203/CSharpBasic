using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic
{

    /// <summary>
    /// this在继承中代表什么？没搞清楚
    /// 【视频里说：this不是代表当前类，代表的是当前对象】
    /// </summary>
    public class ThisKeywordDemo
    {
        public static void Test()
        {
            PersonThis p = new PersonThis();
            PersonThis s1 = new StudentThis();
            StudentThis s2 = new StudentThis();
            Console.WriteLine("----p----"); 
            p.GetStr();

            Console.WriteLine("----s1----");
            s1.GetStr();

            Console.WriteLine("----s2----");
            s2.GetStr();


            /*上面的结果
              ----p----
              CSharpBasic.Basic.PersonThis
              PersonThisppp
              ----s1----
              CSharpBasic.Basic.StudentThis
              PersonThisppp
              ----s2----
              CSharpBasic.Basic.StudentThis
              PersonThisppp

             */


            PersonThis1 p1 = new PersonThis1();
            PersonThis1 s11 = new StudentThis1();
            StudentThis1 s12 = new StudentThis1();
            Console.WriteLine("----p1----");
            p1.GetStr();

            Console.WriteLine("----s11----");
            s11.GetStr();

            Console.WriteLine("----s12----");
            s12.GetStr();

            /*
             * ----p1----
               CSharpBasic.Basic.PersonThis1
               PersonThis1ppp
               ----s11----
               CSharpBasic.Basic.StudentThis1
               StudentThis1sss
               ----s12----
               CSharpBasic.Basic.StudentThis1
               StudentThis1sss
             */
        }

    }

    public class PersonThis
    {
        public string name = "ppp";
        public void PrintName()
        {
            Console.WriteLine("PersonThis" + this.name); ;
        }

        public void GetStr()
        {
            Type t = this.GetType();
            Console.WriteLine(t); ;
            this.PrintName();
        }
    }

    public class StudentThis : PersonThis
    {
        public new string name = "sss";
        public new void PrintName()
        {
            Console.WriteLine("StudentThis" + this.name);
        }
    }


    public class PersonThis1
    {
        public string name = "ppp";
        public virtual void PrintName()
        {
            Console.WriteLine("PersonThis1" + this.name); ;
        }

        public void GetStr()
        {
            Type t = this.GetType();
            Console.WriteLine(t); ;
            this.PrintName();
        }
    }
    public class StudentThis1 : PersonThis1
    {
        public new string name = "sss";
        public override void PrintName()
        {
            Console.WriteLine("StudentThis1" + this.name);
        }
    }
}
