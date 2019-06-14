using CSharpBasic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic
{
    public class NullCheck
    {
        public static void CheckNull()
        {
            Employee person1 = new Employee();
            Employee person2 = null;
            var result1 = "Name:" + person1?.Name + "Id:" + person1?.Id;
            var result2 = "Name:" + person2?.Name + "Id:" + person2?.Id;
            var result3 = person1?.Name ?? "测试3";
            var result4 = person1?.Id ?? 99;
            var result5 = person2?.Name ?? "测试5";
            var result6 = person2?.Id ?? 999;

            Console.WriteLine("result1" + result1);
            Console.WriteLine("result2" + result2);
            Console.WriteLine("result3" + result3);
            Console.WriteLine("result4" + result4);
            Console.WriteLine("result5" + result5);
            Console.WriteLine("result6" + result6);
        }
    }
}
