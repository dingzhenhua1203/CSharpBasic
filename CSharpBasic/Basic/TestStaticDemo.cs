using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic.Basic
{

    public class TestStaticDemo {

        static void Test(string[] args)
        {
            /**
             * 外部配置一开始时111 后来变成222
             * ------------------------普通 class-----------------
               TestCommonService.静态变量=111
               TestCommonService.静态方法()=111
               TestCommonService.静态方法语法糖=>()=111
               TestCommonService.只读属性=111
               TestCommonService.属性=111
               TestCommonService.静态有参方法(true)=true:111
               TestCommonService.静态有参方法(false)=false:111
               ------------------------静态 class-----------------
               TestStaticService.静态变量=111
               TestStaticService.静态方法()=111
               TestStaticService.静态方法语法糖=>()=111
               TestStaticService.只读属性=111
               TestStaticService.属性=111
               TestStaticService.静态有参方法(true)=true:111
               TestStaticService.静态有参方法(false)=false:111
               [14:09:33 INF] [tcbase.configcenter.client](6.5.3) jiesan.netcore.surprisegamepollapi配置项已改变，正在重新加载
                ------------------------普通 class-----------------
               TestCommonService.静态变量=111
               TestCommonService.静态方法()=222
               TestCommonService.静态方法语法糖=>()=222
               TestCommonService.只读属性=222
               TestCommonService.属性=111
               TestCommonService.静态有参方法(true)=true:222
               TestCommonService.静态有参方法(false)=false:222
               ------------------------静态 class-----------------
               TestStaticService.静态变量=111
               TestStaticService.静态方法()=222
               TestStaticService.静态方法语法糖=>()=222
               TestStaticService.只读属性=222
               TestStaticService.属性=111
               TestStaticService.静态有参方法(true)=true:222
               TestStaticService.静态有参方法(false)=false:222
             * 
             **/

            Environment.SetEnvironmentVariable("DAOKEAPPUK", "jiesan.netcore.surprisegamepollapi");
            //ConfigCenterClient.Init(ProjectsEnum.List);

            Console.WriteLine($"------------------------普通 class-----------------");
            Console.WriteLine($"TestCommonService.静态变量={TestCommonService.静态变量}");
            Console.WriteLine($"TestCommonService.静态方法()={TestCommonService.静态方法()}");
            Console.WriteLine($"TestCommonService.静态方法语法糖=>()={TestCommonService.静态方法语法糖()}");
            Console.WriteLine($"TestCommonService.只读属性={TestCommonService.只读属性}");
            Console.WriteLine($"TestCommonService.属性={TestCommonService.属性}");
            Console.WriteLine($"TestCommonService.静态有参方法(true)={TestCommonService.静态有参方法(true)}");
            Console.WriteLine($"TestCommonService.静态有参方法(false)={TestCommonService.静态有参方法(false)}");
            Console.WriteLine($"------------------------静态 class-----------------");
            Console.WriteLine($"TestStaticService.静态变量={TestStaticService.静态变量}");
            Console.WriteLine($"TestStaticService.静态方法()={TestStaticService.静态方法()}");
            Console.WriteLine($"TestStaticService.静态方法语法糖=>()={TestStaticService.静态方法语法糖()}");
            Console.WriteLine($"TestStaticService.只读属性={TestStaticService.只读属性}");
            Console.WriteLine($"TestStaticService.属性={TestStaticService.属性}");
            Console.WriteLine($"TestStaticService.静态有参方法(true)={TestStaticService.静态有参方法(true)}");
            Console.WriteLine($"TestStaticService.静态有参方法(false)={TestStaticService.静态有参方法(false)}");

            Console.ReadKey();
        }
    }


    /// <summary>
    /// 
    /// </summary>
    public class TestCommonService
    {
        /// <summary>
        /// 静态变量
        /// </summary>
        public static string 静态变量 = ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        /// <summary>
        /// 静态方法
        /// </summary>
        /// <returns></returns>
        public static string 静态方法()
        {
            return ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        }
        /// <summary>
        /// 静态方法语法糖
        /// </summary>
        /// <returns></returns>
        public static string 静态方法语法糖() => ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");

        /// <summary>
        /// 只读属性
        /// </summary>
        public static string 只读属性 => ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        /// <summary>
        /// 属性
        /// </summary>
        public static string 属性 { get; set; } = ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");

        /// <summary>
        /// 静态有参方法
        /// </summary>
        /// <param name="isValue"></param>
        /// <returns></returns>
        public static string 静态有参方法(bool isValue)
        {
            return isValue ? $"true:{ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "")}" : $"false:{ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "")}";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class TestStaticService
    {
        /// <summary>
        /// 静态变量
        /// </summary>
        public static string 静态变量 = ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        /// <summary>
        /// 静态方法
        /// </summary>
        /// <returns></returns>
        public static string 静态方法()
        {
            return ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        }
        /// <summary>
        /// 静态方法语法糖
        /// </summary>
        /// <returns></returns>
        public static string 静态方法语法糖() => ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");

        /// <summary>
        /// 只读属性
        /// </summary>
        public static string 只读属性 => ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        /// <summary>
        /// 属性
        /// </summary>
        public static string 属性 { get; set; } = ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");

        /// <summary>
        /// 静态有参方法
        /// </summary>
        /// <param name="isValue"></param>
        /// <returns></returns>
        public static string 静态有参方法(bool isValue)
        {
            return isValue ? $"true:{ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "")}" : $"false:{ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "")}";
        }
    }
}
