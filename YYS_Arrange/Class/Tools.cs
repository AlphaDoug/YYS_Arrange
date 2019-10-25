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
        private static DateTime _dtStart = new DateTime(1970, 1, 1, 8, 0, 0);
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
        /// <summary>
        /// 双精度浮点转面板显示
        /// </summary>
        /// <param name="i">要显示的数值</param>
        /// <param name="isPercentage">是否为百分比显示</param>
        /// <returns></returns>
        public static string Data2String(double i,bool isPercentage)
        {
            if (isPercentage)
            {
                double j = Math.Round(i, 4);
                double m = j * 100;
                if (m.ToString().Contains("."))
                {
                    return m.ToString() + @"%";
                }
                else
                {
                    return m.ToString() + @".00%";
                }
            }
            else
            {
                double j = Math.Round(i, 2);
                if (j.ToString().Contains("."))
                {
                    return j.ToString();
                }
                else
                {
                    return j.ToString() + @".00";
                }
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

        /// <summary> 
        /// 获取时间戳 
        /// </summary>  
        public static string GetTimeStamp(DateTime dateTime)
        {
            return Convert.ToInt64(dateTime.Subtract(_dtStart).TotalMilliseconds).ToString();
        }

        /// <summary> 
        /// 根据时间戳获取时间 
        /// </summary>  
        public static DateTime TimeStampToDateTime(string timeStamp)
        {
            return _dtStart.AddSeconds(Convert.ToInt64(timeStamp));
        }

        /// <summary> 
        /// 根据时间戳获取时间 
        /// </summary>  
        public static DateTime TimeStampToDateTime(long timeStamp)
        {
            if (timeStamp > 0)
            {
                return _dtStart.AddSeconds(timeStamp);
            }
            return DateTime.MinValue;
        }
    }
}
