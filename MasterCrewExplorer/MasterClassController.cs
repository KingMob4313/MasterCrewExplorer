using System.Collections.Generic;
using System.Net;
using System.Configuration;

namespace MasterCrewExplorer
{
    class MasterClassController
    {
        public List<DnDBasicsCharacter> currentDnDList = new List<DnDBasicsCharacter>();
        public object GetMasterCrewData()
        {
            currentDnDList = GetDnDData(new List<DnDBasicsCharacter>());
            return new object();
        }

        private static List<DnDBasicsCharacter> GetDnDData(List<DnDBasicsCharacter> currentDnDList)
        {
            MasterCrewParser mcp = new MasterCrewParser();

            var currentConfig = ConfigurationManager.AppSettings;
            string prefixDataUrl = currentConfig.Get("MasterDataSetPrefix");
            string suffixDataUrl = currentConfig.Get("DnDDataSetSuffix");
            string fullUrl = string.Format(prefixDataUrl, suffixDataUrl);
            string jsonData = GetJsonData(fullUrl);
            object taco = mcp.ParseJsonToDataList(jsonData, new DnD5thCharacter());

            return currentDnDList;
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
