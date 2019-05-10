using ListDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person _person = new Person() { PId = 1, PName = "luffy", PSex = "男", PAge = 18, DataFlag = true };
            List<Person> personList = new List<Person>();
            personList.Add(_person);
            personList.Add(new Person() { PId = 2, PName = "chorbar", PSex = "男", PAge = 16, DataFlag = false });
            personList.Add(new Person() { PId = 3, PName = "nami", PSex = "女", PAge = 20, DataFlag = true });
            personList.Add(new Person() { PId = 4, PName = "frank", PSex = "中", PAge = 20, DataFlag = true });
            Console.WriteLine("---------------------------分割线---------------------------------------");

            #region List.Any()用法 判断List是否包含指定条件的元素 需引用System.Linq命名空间
            bool b1 = personList.Any();
            bool b2 = personList.Any(p => p.PId == 1);
            bool b3 = personList.Any(p => p.PId == 10);
            bool b4 = personList.Any((p) => { return p.PId == 1; });

            Console.WriteLine("b1=" + b1.ToString() + ".....b2=" + b2.ToString() + ".....b3=" + b3.ToString() + ".....b4=" + b4.ToString());  //true true false true
            #endregion

            Console.WriteLine("---------------------------分割线---------------------------------------");

            #region List.Foreach()处理List元素
            Console.WriteLine("List.Foreach()处理List元素");
            personList.Where(p => p.DataFlag == true & p.PName == "luffy").ToList().ForEach(m => m.DataFlag = false);
            personList.Where(p => p.PName == "luffy").First().PAge = 100;
            foreach (Person item in personList)
            {
                Console.WriteLine("List元素:" + item.ToString());
            }
            #endregion

            Console.WriteLine("---------------------------分割线---------------------------------------");

            #region  List.Where()用法 筛选出满足指定条件的集合return出去，本身内容不变
            List<Person> listMan = personList.Where(p => p.PSex == "男").ToList();
            bool b5 = personList.Where(p => p.PId == 1).Count() > 0;
            bool b6 = personList.Where(p => p.PId == 10).Count() > 0;
            string pname1 = personList.Where(p => p.PId == 1).ToList().FirstOrDefault().PName;
            var listttt = personList.Where(p => p.PId == 10);
            var listttt2 = personList.Where(p => p.PId == 10).ToList(); //无问题 count=0
            bool res = personList.Where(p => p.PId == 10).ToList().FirstOrDefault() == null;
            //string pname2 = personList.Where(p => p.PId == 10).ToList().FirstOrDefault().PName;  //报错 需要进行验证null判定

            Console.WriteLine("b5=" + b5.ToString() + ".....b6=" + b6.ToString()); //True False
            Console.WriteLine("pname1=" + pname1 + " res=" + res.ToString());  //True
            #endregion

            Console.WriteLine("---------------------------分割线---------------------------------------");

            #region List.Select()用法 检索出括号相应的内容，相当于sql的select
            var result = personList.Select(p => p.PName).ToList();
            var result2 = personList.Select(p => new { p.PName, p.PSex }).ToList();
            Console.WriteLine("打印出List.Select()的结果");
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
            foreach (var item in result2)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion

            Console.WriteLine("---------------------------分割线---------------------------------------");

            #region 修改List中的对象的属性值
            var temp = personList.Find(p => p.PName == "luffy");
            Console.WriteLine("修改List中的元素值前AGE=" + temp.PAge);
            temp.PAge = 20;
            Console.WriteLine("修改List中的元素值后AGE=" + temp.PAge);
            var temp2 = personList.Find(p => p.PName == "luffy");
            Console.WriteLine("修改List中的元素值后List中的元素的AGE=" + temp2.PAge);
            #endregion
            Console.WriteLine("---------------------------分割线---------------------------------------");
            #region List分组
            Console.WriteLine("List分组");
            int count = personList.GroupBy(p => p.PSex).Count();
            Console.WriteLine("List分组个数："+ count);
            #endregion

            Console.WriteLine("---------------------------分割线---------------------------------------");

            #region
            #endregion

            #region
            #endregion

            #region List三种去重方法
            List<User> users = new List<User>();
            users.Add(new User("张三", "永丰路299号"));
            users.Add(new User("张三", "上地西路8号"));//重复项，去重后将删掉  
            users.Add(new User("李四", "海鹰路甲一号"));

            Console.WriteLine("List三种去重方法");
            #region 1.实现Equals方法来去重
            List<User> nonDuplicateList1 = users.Distinct().ToList();//通过User类的Equals实现去重 
            #endregion

            #region 2.Lambda表达式去重
//nonDuplicateList2 名称必须和原来的users不一样
            List<User> nonDuplicateList2 = users.Where((x, i) => users.FindIndex(z => z.name == x.name) == i).ToList();
            #endregion

            #region 3.循环去重
            List<User> nonDuplicateList3 = new List<User>();//通过循环方式去重  
            foreach (User user in users)
            {
                if (nonDuplicateList3.Exists(x => x.name == user.name) == false)
                {
                    nonDuplicateList3.Add(user);
                }
            }
            #endregion

            foreach (List<User> listItem in new Object[] { nonDuplicateList1, nonDuplicateList2, nonDuplicateList3 })//打印出三个List的元素  
            {
                Console.Write("nonDuplicateList:\r\n");
                foreach (User u in listItem)
                {
                    Console.WriteLine("\t" + u.ToString());
                }
            }

            #endregion

            Console.WriteLine("---------------------------分割线---------------------------------------");
            #region List测试参数传递问题是地址传递还是新开空间
            List<Person> testList = new List<Person>();
            testList.Add(new Person() { PId = 1, PName = "luffy", PSex = "男", PAge = 18, DataFlag = true });
            testList.Add(new Person() { PId = 2, PName = "chorbar", PSex = "男", PAge = 16, DataFlag = false });
            testList.Add(new Person() { PId = 3, PName = "nami", PSex = "女", PAge = 20, DataFlag = true });
            Console.WriteLine("开始前：testList=" + testList.FirstOrDefault().PAge);//18
            TestList(testList);
            Console.WriteLine("开始后：testList=" + testList.FirstOrDefault().PAge);//100
            #endregion

            Console.WriteLine("---------------------------分割线---------------------------------------");
            #region List测试参数传递问题是地址传递还是新开空间
            List<Person> testList2 = new List<Person>();
            testList2.Add(new Person() { PId = 1, PName = "luffy", PSex = "男", PAge = 18, DataFlag = true });
            testList2.Add(new Person() { PId = 2, PName = "chorbar", PSex = "男", PAge = 16, DataFlag = false });
            testList2.Add(new Person() { PId = 3, PName = "chorbar", PSex = "女", PAge = 16, DataFlag = false });
            testList2.Add(new Person() { PId = 4, PName = "chorbar", PSex = "女", PAge = 16, DataFlag = false });
            testList2.Add(new Person() { PId = 5, PName = "nami", PSex = "女", PAge = 20, DataFlag = true });
            var list = testList2.Where(p => p.PName == "chorbar").ToList();//也是地址的传递，会影响到testList2的结果
            TestList(list);
            foreach (var u in testList2)
            {
                Console.WriteLine("\t" + u.ToString());
            }
            #endregion

            Console.Read();
        }

        public static void TestList(List<Person> temp)
        {
            temp.FirstOrDefault().PSex = "中性";
        }
    }
}
