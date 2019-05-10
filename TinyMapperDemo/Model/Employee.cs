using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyMapperDemo.Model
{
    public class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public int EAge { get; set; }
        public string EAddress { get; set; }
        public DateTime EBirth { get; set; }
        public List<HomeMember> HomeList { get; set; }
    }

    public class HomeMember
    {
        public string Name { get; set; }
        public string GuanXi { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
