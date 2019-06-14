using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic.AttributeLib.CustomAttributes
{
    public class DzhTestAttribute : Attribute
    {
        public DzhTestAttribute() { }

        public DzhTestAttribute(string name, string verison) {
            Name = name;
            Date = DateTime.Now.ToShortDateString();
        }

        public string Name { get; set; }
        public string Date { get; set; }
        public string Describtion { get; set; }
    }
}
