using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic.BasicKnowledge
{
    class Dog :IAnimal
    {
        public void Eat() {
            Console.WriteLine("DOG EAT");
            Console.ReadKey();
        }
        public void Sleep() {
            Console.WriteLine("DOG Sleep");
            Console.ReadKey();
        }
    }
}
