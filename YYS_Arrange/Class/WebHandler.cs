using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.IO.Compression;
using System.Windows.Forms;

namespace Web

{
    /// <summary>  
    /// 公共方法类  
    /// </summary>  
    public class WebHandler
    {
        /// <summary>  
        /// 获取网页的HTML码  
        /// </summary>  
        /// <param name="url">链接地址</param>  
        /// <param name="encoding">编码类型</param>  
        /// <returns></returns>  
        public static string GetHtmlStr(string url, Encoding encoding)
        {
            string htmlStr = "";
            try
            {
                if (!String.IsNullOrEmpty(url))
                {

                    WebRequest request = WebRequest.Create(url);            //实例化WebRequest对象  
                    
                    WebResponse response = request.GetResponse();           //创建WebResponse对象  
                   
                    Stream datastream = response.GetResponseStream();       //创建流对象  
                    StreamReader reader = new StreamReader(datastream, encoding);
                    htmlStr = reader.ReadToEnd();                  //读取网页内容  
                    reader.Close();
                    datastream.Close();
                    response.Close();
                }
            }
            catch { }
            return htmlStr;
        }

        public static string HttpGetString(string url)
        {
            string html;
            HttpWebRequest Web_Request = (HttpWebRequest)WebRequest.Create(url);
            Web_Request.Timeout = 30000;
            Web_Request.Method = "GET";
            Web_Request.UserAgent = "Mozilla/4.0";
            Web_Request.Headers.Add("Accept-Encoding", "gzip, deflate");
            //Web_Request.Credentials = CredentialCache.DefaultCredentials;

            //设置代理属性WebProxy-------------------------------------------------
            //WebProxy proxy = new WebProxy("111.13.7.120", 80);
            //在发起HTTP请求前将proxy赋值给HttpWebRequest的Proxy属性
            //Web_Request.Proxy = proxy;

            HttpWebResponse Web_Response = (HttpWebResponse)Web_Request.GetResponse();

            if (Web_Response.ContentEncoding.ToLower() == "gzip")  // 如果使用了GZip则先解压
            {
                using (Stream Stream_Receive = Web_Response.GetResponseStream())
                {
                    using (var Zip_Stream = new GZipStream(Stream_Receive, CompressionMode.Decompress))
                    {
                        using (StreamReader Stream_Reader = new StreamReader(Zip_Stream, Encoding.UTF8))
                        {
                            html = Stream_Reader.ReadToEnd();
                        }
                    }
                }
            }
            else
            {
                using (Stream Stream_Receive = Web_Response.GetResponseStream())
                {
                    using (StreamReader Stream_Reader = new StreamReader(Stream_Receive, Encoding.UTF8))
                    {
                        html = Stream_Reader.ReadToEnd();
                    }
                }
            }

            return html;
        }

        public static void WebStringGet(string url)
        {
            int hitCount = 0;

            WebBrowser browser = new WebBrowser();

            browser.ScriptErrorsSuppressed = true;

            browser.Navigating += (sender, e) =>
            {
                hitCount++;
            };

            browser.DocumentCompleted += (sender, e) =>
            {
                hitCount++;
            };

            browser.Navigate(url);

            while (browser.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }

            while (hitCount < 16)
                Application.DoEvents();

            var htmldocument = browser.DocumentText;

        }


    }
   
}