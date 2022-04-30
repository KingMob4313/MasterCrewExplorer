using Newtonsoft.Json;

namespace MasterCrewExplorer
{
    class MasterCrewParser
    {
        //Need to divide the json objects into individual lists of objects
        public dynamic taco(string jsonString)
        {
            dynamic burrito = JsonConvert.DeserializeObject(jsonString);
            return burrito;
        }
    }
}

