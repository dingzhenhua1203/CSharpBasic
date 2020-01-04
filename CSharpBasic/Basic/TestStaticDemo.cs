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
                TestStaticService.GetConfigId1=111
                TestStaticService.GetConfigId2()=111
                TestStaticService.GetConfigId3()=111
                TestStaticService.GetConfigId4=111
                TestStaticService.GetConfigId5=111
                TestStaticService.GetInstance(true)=true
                TestStaticService.GetInstance(false)=false
                ------------------------static class-----------------
                TestStaticService2.GetConfigId1=111
                TestStaticService2.GetConfigId2()=111
                TestStaticService2.GetConfigId3()=111
                TestStaticService2.GetConfigId4=111
                TestStaticService2.GetConfigId5=111
                TestStaticService2.GetInstance(true)=true:111
                TestStaticService2.GetInstance(false)=false:111
                [13:32:00 INF] [tcbase.configcenter.client](6.5.3) jiesan.netcore.surprisegamepollapi配置项已改变，正在重新加载
                 ------------------------普通 class-----------------
                TestStaticService.GetConfigId1=111
                TestStaticService.GetConfigId2()=222
                TestStaticService.GetConfigId3()=222
                TestStaticService.GetConfigId4=222
                TestStaticService.GetConfigId5=111
                TestStaticService.GetInstance(true)=true
                TestStaticService.GetInstance(false)=false
                ------------------------static class-----------------
                TestStaticService2.GetConfigId1=111
                TestStaticService2.GetConfigId2()=222
                TestStaticService2.GetConfigId3()=222
                TestStaticService2.GetConfigId4=222
                TestStaticService2.GetConfigId5=111
                TestStaticService2.GetInstance(true)=true:222
                TestStaticService2.GetInstance(false)=false:222
             * 
             **/

            Environment.SetEnvironmentVariable("DAOKEAPPUK", "jiesan.netcore.surprisegamepollapi");

            Console.WriteLine($"------------------------普通 class-----------------");
            Console.WriteLine($"TestStaticService.GetConfigId1={TestStaticService.GetConfigId1}");
            Console.WriteLine($"TestStaticService.GetConfigId2()={TestStaticService.GetConfigId2()}");
            Console.WriteLine($"TestStaticService.GetConfigId3()={TestStaticService.GetConfigId3()}");
            Console.WriteLine($"TestStaticService.GetConfigId4={TestStaticService.GetConfigId4}");
            Console.WriteLine($"TestStaticService.GetConfigId5={TestStaticService.GetConfigId5}");
            Console.WriteLine($"TestStaticService.GetInstance(true)={TestStaticService.GetInstance(true)}");
            Console.WriteLine($"TestStaticService.GetInstance(false)={TestStaticService.GetInstance(false)}");
            Console.WriteLine($"------------------------static class-----------------");
            Console.WriteLine($"TestStaticService2.GetConfigId1={TestStaticService2.GetConfigId1}");
            Console.WriteLine($"TestStaticService2.GetConfigId2()={TestStaticService2.GetConfigId2()}");
            Console.WriteLine($"TestStaticService2.GetConfigId3()={TestStaticService2.GetConfigId3()}");
            Console.WriteLine($"TestStaticService2.GetConfigId4={TestStaticService2.GetConfigId4}");
            Console.WriteLine($"TestStaticService2.GetConfigId5={TestStaticService2.GetConfigId5}");
            Console.WriteLine($"TestStaticService2.GetInstance(true)={TestStaticService2.GetInstance(true)}");
            Console.WriteLine($"TestStaticService2.GetInstance(false)={TestStaticService2.GetInstance(false)}");

            Console.ReadKey();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public class TestStaticService
    {
        /// <summary>
        /// 静态变量
        /// </summary>
        public static string GetConfigId1 = ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        /// <summary>
        /// 静态方法
        /// </summary>
        /// <returns></returns>
        public static string GetConfigId2()
        {
            return ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        }
        /// <summary>
        /// 静态方法语法糖
        /// </summary>
        /// <returns></returns>
        public static string GetConfigId3() => ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");

        /// <summary>
        /// 只读属性
        /// </summary>
        public static string GetConfigId4 => ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        /// <summary>
        /// 属性
        /// </summary>
        public static string GetConfigId5 { get; set; } = ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");

        /// <summary>
        /// 静态方法
        /// </summary>
        /// <param name="isValue"></param>
        /// <returns></returns>
        public static string GetInstance(bool isValue)
        {
            return isValue ? "true" : "false";
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public static class TestStaticService2
    {
        /// <summary>
        /// 静态变量
        /// </summary>
        public static string GetConfigId1 = ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        /// <summary>
        /// 静态方法
        /// </summary>
        /// <returns></returns>
        public static string GetConfigId2()
        {
            return ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        }
        /// <summary>
        /// 静态方法语法糖
        /// </summary>
        /// <returns></returns>
        public static string GetConfigId3() => ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");

        /// <summary>
        /// 只读属性
        /// </summary>
        public static string GetConfigId4 => ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");
        /// <summary>
        /// 属性
        /// </summary>
        public static string GetConfigId5 { get; set; } = ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "");

        /// <summary>
        /// 静态方法
        /// </summary>
        /// <param name="isValue"></param>
        /// <returns></returns>
        public static string GetInstance(bool isValue)
        {
            return isValue ? $"true:{ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "")}" : $"false:{ConfigHelper.TryGetOtherProject(ProjectsEnum.SurpriseGamePollApi, "ConfigId", "")}";
        }
    }
}
