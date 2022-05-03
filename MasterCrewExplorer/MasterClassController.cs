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
            var ax = ConfigurationManager.AppSettings;
            string prefixDataUrl = ax.Get("MasterDataSetPrefix");
            string suffixDataUrl = ax.Get("DnDDataSetSuffix");
            string fullUrl = prefixDataUrl + suffixDataUrl;
            string jsondata = GetJsonData(fullUrl);
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
