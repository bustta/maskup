using HtmlAgilityPack;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace feeder
{
    public class RequestAgent
    {
        private string _GetAirDataFromPage()
        {
            string res = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://taqm.epa.gov.tw/taqm/tw/PsiMap.aspx");
            request.Method = "GET";
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; Windows NT 5.2; Windows NT 6.0; Windows NT 6.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727; MS-RTC LM 8; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET CLR 4.0C; .NET CLR 4.0E)";
            request.Timeout = 10000;

            using (WebResponse response = request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader streamReader = new StreamReader(stream))
                    {
                        res = streamReader.ReadToEnd();
                    }
                }
            }

            return res;
        }

        public List<string> GetAllAirDataFromRequest()
        {
            string htmlStr = _GetAirDataFromPage();

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(htmlStr);
            HtmlNodeCollection nodeCollection = document.DocumentNode.SelectNodes("//area");
            List<string> targetList = new List<string>();
            foreach (HtmlNode node in nodeCollection)
            {
                if (node.Attributes["jTitle"] == null) continue;

                string targetInfo = node.Attributes["jTitle"].Value;
                targetList.Add(targetInfo);
            }

            return targetList;
        }
    }
}