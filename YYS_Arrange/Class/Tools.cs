using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYS_Arrange.Class
{
    class Tools
    {

        // 从一个对象信息生成Json串
        public static string ObjectToJson(object obj)
        {
            try
            {
                return JsonConvert.SerializeObject(obj);
            }
            catch (Exception)
            {
                return "";
                throw;
            }
            
        }
        // 从一个Json串生成对象信息
        public static object JsonToObject(string jsonString, object obj)
        {          
            try
            {
                return JsonConvert.DeserializeObject(jsonString, obj.GetType());
            }
            catch (Exception)
            {
                return null;
                throw;
            }          
        }

        public static string Data2String(string str)
        {
            return str;
        }
        public static string Data2String(int i)
        {
            if (i >= 10000 && i < 100000000)
            {
                int j = i / 100;
                float k = j;
                k = k / 100.0f;
                return k.ToString() + "万";
            }
            else if(i >= 100000000)
            {
                int j = i / 1000000;
                float k = j;
                k = k / 100.0f;
                return k.ToString() + "亿";
            }
            else
            {
                return i.ToString();
            }
        }

        public static string Data2String(double i,bool isPercentage)
        {
            if (isPercentage)
            {
                double j = i * 10000;
                int k = (int)j;
                float m = k / 100;
                return m.ToString() + @"%";
            }
            else
            {
                double j = i * 100;
                int k = (int)j;
                float m = k / 100;
                return m.ToString();
            }
        }

        /// <summary>
        /// 执行JS
        /// </summary>
        /// <param name="sExpression">参数体</param>
        /// <param name="sCode">JavaScript代码的字符串</param>
        /// <returns></returns>
        private string ExecuteScript(string sExpression, string sCode)
        {
            MSScriptControl.ScriptControl scriptControl = new MSScriptControl.ScriptControl
            {
                UseSafeSubset = true,
                Language = "JScript"
            };
            scriptControl.AddCode(sCode);
            try
            {
                string str = scriptControl.Eval(sExpression).ToString();
                return str;
            }
            catch (Exception ex)
            {
                string str = ex.Message;
            }
            return null;
        }
    }
}
