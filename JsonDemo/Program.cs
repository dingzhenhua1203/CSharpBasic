
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> inputParams = new Dictionary<string, string>();
            inputParams.Add("#travelDate", "1990-0-9");
            inputParams.Add("#sceneryName", "hhh");
            inputParams.Add("#productName", "");
            inputParams.Add("#tickets", "");
            inputParams.Add("#errorMessage", "");
            inputParams.Add("#shortNum", "");

            Console.WriteLine(JsonConvert.SerializeObject(inputParams));
            string json = "{ 'Notelist':[{'isDelete':false,'WarmPromptDescS1tring':'hahahh'},{'isDelete':true,'WarmPromptDescString':'heheh'}]}";

            #region 处理温馨提示
            string warm = json;
            if (warm.Contains("Notelist"))
            {
                StringBuilder sb = new StringBuilder();
                JObject obj = (JObject)JsonConvert.DeserializeObject(warm);  //序列化（也可使用JToken代替JObject）
                for (int i = 0; i < obj["Notelist"].Count(); i++)
                {
                    sb.Append(obj["Notelist"][i]["WarmPromptDescString"]);//Append方法自带null值过滤
                    if (i != 0)
                    {
                        sb.Append("<br/>");
                    }
                }
                warm = sb.ToString();
            }
            Console.WriteLine(warm);
            Console.WriteLine("...........................");
            #endregion

            #region 序列化
            Employee eml = new Employee() { EmpId = "0001", EmpName = "NAMI", EmpAge = 25, Birth = DateTime.Parse("2017-11-01") };
            string emlStr = JsonConvert.SerializeObject(eml); //{"EmpId":"0001","EmpName":"NAMI","EmpAge":25,"Sex":0,"Address":"上海"}
            Console.WriteLine(emlStr);
            Console.WriteLine("...........................");
            #endregion
            #region 反序列化
            string empStr2="{'EmpId':'0001','EmpName':'NAMI','EmpAge':25}";//缺字段
            string empStr3 = "{'EmpId':'0001','EmpName':'NAMI','EmpAge':25,'Address':'上海'}";//多字段
            var model2 = JsonConvert.DeserializeObject<Employee>(empStr2);//不报错，能转化
            var model3 = JsonConvert.DeserializeObject<Employee>(empStr3);//不报错，能转化
            model3.EmpId = "0002";
            var ss = JsonConvert.SerializeObject(model3);
            Console.WriteLine(".............结束..............");

            GroupComboJson jsonStr = new GroupComboJson();
            var ss33 = JsonConvert.SerializeObject(jsonStr);
            #endregion

            string TPDGroupCombo = @"{'Radio':0,'Radio_No_0':1,'Radio_Str':null,'Radio_No_1':1,'Check':false}
";
            if (!string.IsNullOrWhiteSpace(TPDGroupCombo))
            {
                GroupComboJson _groupComboJson = JsonConvert.DeserializeObject<GroupComboJson>(TPDGroupCombo);
                if (_groupComboJson != null)
                {
                    _groupComboJson.TPDPickupDelivery.PickupDeliveryServiceType = 3;
                }
                TPDGroupCombo = JsonConvert.SerializeObject(_groupComboJson);
            }


            Console.Read();
        }
    }
}
