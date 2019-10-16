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

    }
}
