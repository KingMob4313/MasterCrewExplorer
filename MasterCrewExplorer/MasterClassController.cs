using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MasterCrewExplorer
{
    class MasterClassController
    {
        public object GetMasterCrewData(string url)
        {
            string jsonData = GetJsonData(url);
            MasterCrewParser mcp = new MasterCrewParser();
            var xxx = mcp.taco(jsonData);
            return xxx;
        }

        private static string GetJsonData(string url)
        {
            using (WebClient currentWebClient = new WebClient())
            {
                string json = currentWebClient.DownloadString(url);
                return json;
            }
        }
    }
}
