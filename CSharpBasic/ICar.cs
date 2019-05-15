using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    interface ICar
    {
        //接口中方法不能用修饰符public等


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        void Drive(string name);

        bool AddOil(string name, int money);
    }
}
