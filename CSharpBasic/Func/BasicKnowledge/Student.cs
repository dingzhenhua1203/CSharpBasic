using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Func.BasicKnowledge
{
    public class Student : Person
    {
        public override string Sex
        {
            get;
            set;
        }
        public override void DoAction()
        {
            Console.WriteLine("Student Study");
            Console.ReadKey();
        }
        public override void DoAction1()
        {
            Console.WriteLine("Student");
            Console.ReadKey();
        }
    }
}
