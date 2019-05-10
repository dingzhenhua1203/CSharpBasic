using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nelibur.ObjectMapper;
using TinyMapperDemo.Model;
using System.Reflection;
using System.Diagnostics;

namespace TinyMapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                EId = 1,
                EName = "Luffy",
                EAge = 23,
                EAddress = "jiangsu",
                EBirth = DateTime.Now,
                HomeList = new List<HomeMember>() {
                    new HomeMember() {Name="ABC", GuanXi="Wife",CreateDate=DateTime.Now},
                    new HomeMember() { Name = "HHH", GuanXi = "Son" ,CreateDate=DateTime.Now}
                }
            };

            EmployeeDTO eto = new EmployeeDTO();
            List<Employee> emplist = new List<Employee>();
            List<EmployeeDTO> etoList = new List<EmployeeDTO>();
            for (int i = 0; i < 1000000; i++)
            {
                emplist.Add(e1);
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();

            #region tinyMapper
            //绑定映射规则， 名称一模一样可以省略不写
            TinyMapper.Bind<HomeMember, HomeMemberDTO>(
                config =>
                    {
                        config.Bind(x => x.Name, y => y.name);
                        config.Bind(x => x.GuanXi, y => y.guanxi);
                    }
            );
            TinyMapper.Bind<Employee, EmployeeDTO>(
                config =>
                    {
                        config.Ignore(x => x.EAge);//忽略ID字段

                        //将源类型和目标类型的字段对应绑定起来
                        config.Bind(x => x.EId, y => y.eid);
                        config.Bind(x => x.EName, y => y.ename);
                        config.Bind(x => x.EAge, y => y.eage);
                        config.Bind(x => x.HomeList, y => y.homelist);
                    }
                );
            sw.Start();
            var etoList22 = TinyMapper.Map<List<EmployeeDTO>>(new List<Employee>().Where(p=>p.EId==0).ToList());
            etoList = TinyMapper.Map<List<EmployeeDTO>>(emplist);

            #endregion

            long t1 = sw.ElapsedMilliseconds;
            sw.Restart();
            #region 原始方式
            foreach (var tt in emplist)
            {
                eto.eid = tt.EId;
                eto.ename = tt.EName;
                eto.EAddress = tt.EAddress;
                HomeMemberDTO model = null;
                foreach (var item in tt.HomeList)
                {
                    model = new HomeMemberDTO();
                    model.name = item.Name;
                    model.guanxi = item.GuanXi;
                    eto.homelist.Add(model);
                }
                etoList.Add(eto);
            }
            #endregion
            long t2 = sw.ElapsedMilliseconds;
            sw.Stop();
            Console.WriteLine("t1..." + t1.ToString() + "....t2.." + t2.ToString());
            Console.WriteLine("END");
            Console.ReadKey();
        }

        /// <summary>
        /// 将第一个实体对象转换为第二个实体对象
        /// </summary>
        /// <typeparam name="T1">第一个实体对象</typeparam>
        /// <typeparam name="T2">第二个实体对象</typeparam>
        /// <param name="source">转换的实体对象</param>
        /// <returns></returns>
        public T2 CopyToModel<T1, T2>(T1 source)
        {
            T2 model = default(T2);
            PropertyInfo[] pi = typeof(T2).GetProperties();
            PropertyInfo[] pi1 = typeof(T1).GetProperties();

            model = Activator.CreateInstance<T2>();
            for (int i = 0; i < pi.Length; i++)
            {
                for (int j = 0; j < pi1.Length; j++)
                {
                    if (pi[i].Name == pi1[j].Name)
                    {
                        pi[i].SetValue(model, pi1[j].GetValue(source, null), null);
                    }
                }
            }

            return model;
        }
    }
}
