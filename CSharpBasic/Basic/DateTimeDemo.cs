using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic
{
    public class DateTimeDemo
    {
        public static void TestDemo()
        {
            TimeSpan ts = DateTime.Now - DateTime.Parse("2017/3/24 19:19:00");
            DateTime tem = DateTime.Parse("2017-11-01");
            string ss = tem.ToString("yyyyMMdd");
            DateTime today = DateTime.Today;//当前日期{2016/9/14 0:00:00}
            DateTime monthStart = today.AddDays(1 - today.Day); //月初
            DateTime monthEnd = today.AddDays(1 - today.Day).AddMonths(1).AddDays(-1);//月末
            DateTime preMonthStart = today.AddDays(1 - today.Day).AddMonths(-1);//上月初
            DateTime preMonthEnd = today.AddDays(1 - today.Day).AddDays(-1); //上月末
            DateTime nextMonthStart = today.AddDays(1 - today.Day).AddMonths(1); //下个月初
            DateTime nextMonthEnd = today.AddDays(1 - today.Day).AddMonths(2).AddDays(-1); //下个月末

            Console.WriteLine(monthStart.ToString() + "..." + nextMonthStart.ToString() + "..." + monthEnd.ToString());

            Console.ReadLine();
        }

        /// <summary>
        /// 取得某月的第一天
        /// </summary>
        /// <param name="datetime">要取得月份第一天的时间</param>
        /// <returns></returns>
        public static DateTime FirstDayOfMonth(DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day);
        }

        /// <summary>
        /// 取得某月的最后一天
        /// </summary>
        /// <param name="datetime">要取得月份最后一天的时间</param>
        /// <returns></returns>
        public static DateTime LastDayOfMonth(DateTime datetime)
        {
            return datetime.AddDays(1 - datetime.Day).AddMonths(1).AddDays(-1);
        }


    }
}
