using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo.Model
{
    public class Person
    {

        public int PId { get; set; }

        public string PName { get; set; }

        public string PSex { get; set; }

        public int PAge { get; set; }

        public bool DataFlag { get; set; }

        public override string ToString()
        {
            return string.Format("PId:{0},\tPName:{1},\tPSex:{2},\tPAge:{3},\tDataFlag:{4}", PId, PName, PSex, PAge, DataFlag);
        }

    }
}
