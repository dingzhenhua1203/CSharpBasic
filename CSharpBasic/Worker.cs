using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class Worker
    {
        public Worker()
        {
            Console.WriteLine("加载Employee");
        }

        public Worker(int level)
        {
            Console.WriteLine($"加载Employee,等级{level}");
        }
    }

    public class Saler : Worker
    {
        public Saler() : base()  // net 默认会调用父类的无参构造方法，因此: base()可以省略不写。
        {
            Console.WriteLine("加载Saler");
        }
    }

    public class Leader : Worker
    {
        public Leader(int level) : base(level)  // 但是如果父类有多个构造方法，且想要调用父类有参的构造方法则指明出来
        {
            Console.WriteLine("Leader");
        }
    }
}
