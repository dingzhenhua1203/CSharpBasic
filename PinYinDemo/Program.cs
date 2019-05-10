using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinYinDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string hanzi = "中国，水电焊加工“ 哈哈'sdfh 是我";
            var s = PYConvertHelper.GetFirstPinyin(hanzi);
            var s2 = PYConvertHelper.GetPinyin(hanzi);
        }
    }
}
