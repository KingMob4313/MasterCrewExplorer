using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace MasterCrewExplorer
{
    class MasterCrewParser
    {
        //Need to divide the json objects into individual lists of objects
        public Person ParseJsonToDataList(string jsonString, Person currentPerson)
        {
            throw new NotImplementedException();
        }

        public DnD5thCharacter ParseJsonToDataList(string jsonString, DnD5thCharacter currentDnDCharacter)
        {
            //var xyz = JsonConvert.DeserializeObject(jsonString, typeof));
            var abc = JsonConvert.DeserializeObject<List<DnD5thCharacter>>(jsonString);
            return currentDnDCharacter;
        }
    }
}

