using CallName.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallName.Repository
{
    public class PersonRepository
    {
        public static  List<Person> GetPersonList() {
            List<Person> personList = new List<Person>();
            personList.Add(new Person() { No = "33294",Name= "路飞" });
            personList.Add(new Person() { No = "33294", Name = "索隆" });
            personList.Add(new Person() { No = "33294", Name = "娜美" });
            personList.Add(new Person() { No = "33294", Name = "山治" });
            personList.Add(new Person() { No = "33294", Name = "乔巴" });
            personList.Add(new Person() { No = "33294", Name = "罗宾" });
            personList.Add(new Person() { No = "33294", Name = "弗兰奇" });
            personList.Add(new Person() { No = "33294", Name = "布鲁克" });
            personList.Add(new Person() { No = "33294", Name = "罗" });
            personList.Add(new Person() { No = "33294", Name = "艾斯" });
            personList.Add(new Person() { No = "33294", Name = "白胡子" });
            return personList;
        }
    }
}
