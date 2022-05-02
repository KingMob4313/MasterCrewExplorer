using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MasterCrewExplorer
{
    class MasterCrewParser
    {
        //Need to divide the json objects into individual lists of objects
        public dynamic taco(string jsonString)
        {
            var burrito = JsonConvert.DeserializeObject(jsonString);
            
            return burrito;
        }
    }
}

