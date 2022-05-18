using System.Collections.Generic;
using System.Net;
using System.Configuration;
using System.IO;
using System.Text;

namespace MasterCrewExplorer
{
    class MasterClassController
    {
        public List<DnDBasicsCharacter> currentDnDList = new List<DnDBasicsCharacter>();
        public object GetMasterCrewData(string fileLocation)
        {
            currentDnDList = GetDnDData(new List<DnDBasicsCharacter>(), fileLocation);
            return new object();
        }

        private static List<DnDBasicsCharacter> GetDnDData(List<DnDBasicsCharacter> currentDnDList, string fileName)
        {
            string fullUrl = string.Empty;
            string jsonData = string.Empty;
            Encoding jsonFileEncoding = null;
            MasterCrewParser mcp = new MasterCrewParser();

            var currentConfig = ConfigurationManager.AppSettings;
            string prefixDataUrl = currentConfig.Get("MasterDataSetPrefix");
            string suffixDataUrl = currentConfig.Get("DnDDataSetSuffix");
            if(fileName == string.Empty)
            {
                fullUrl = string.Format(prefixDataUrl, suffixDataUrl);
                jsonData = GetJsonData(fullUrl);
            }
            else
            {
                jsonFileEncoding = GetFileEncoding(fileName);
                string[] allJSONFileText = File.ReadAllLines(fileName, jsonFileEncoding);
                jsonData = string.Join("\r\n",allJSONFileText);
            }

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

        private static Encoding GetFileEncoding(string filename)
        {
            Encoding currentEncoding = null;
            using (var reader = new StreamReader(filename, Encoding.UTF8, true))
            {
                reader.Peek(); // you need this!
                currentEncoding = reader.CurrentEncoding;
            }
            return currentEncoding;
        }
    }
}
