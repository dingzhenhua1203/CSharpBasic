using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic.BasicKnowledge
{
    public class Employee:Person
    {
        public override string Sex
        {
            get;
            set;
        }
        public override void DoAction()
        {
            Console.WriteLine("Emp Do Job!");
            Console.ReadKey();
        }
        public override void DoAction1()
        {
            Console.WriteLine("Employee");
            Console.ReadKey();
        }
    }
}
