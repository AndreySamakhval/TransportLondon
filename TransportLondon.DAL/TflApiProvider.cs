using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Tfl.Api.Presentation.Entities;

namespace TransportLondon.DAL
{
    public class TflApiProvider : ITflProvider
    {
        private const string AppID = "292f5d74";
        private const string Key = "3a7b5c90d215148b1f642257236147db";
        private readonly string appParameters;

        public TflApiProvider()
        {
            appParameters = string.Format("app_id={0}&app_key={1}", AppID, Key);
        }

        //get json-string
        public string GetJson(string url, string parameters = "")
        {
            string result="";

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url + "?" + parameters + appParameters);
            request.ContentType = "application / json; charset = utf - 8";
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                    using (StreamReader stream = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        result = stream.ReadToEnd();
                    }
                response.Close();               
            }
            catch(WebException)
            {
                result = null;
            }
            return result;
        }
    }
}
