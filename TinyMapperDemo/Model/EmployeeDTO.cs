using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyMapperDemo.Model
{
    public class EmployeeDTO
    {
        public EmployeeDTO() {
            homelist = new List<HomeMemberDTO>();
        }
        public int eid { get; set; }
        public string ename { get; set; }
        public int eage { get; set; }
        public string EAddress { get; set; }
        public List<HomeMemberDTO> homelist { get; set; }
    }

    public class HomeMemberDTO
    {
        public string name { get; set; }
        public string guanxi { get; set; }
    }
}
