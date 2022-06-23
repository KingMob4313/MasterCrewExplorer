using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;

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
            DnD35Character currentC = new DnD35Character();
            //var xyz = JsonConvert.DeserializeObject(jsonString);
            var jss = new JavaScriptSerializer();
            List<DnD5thCharacter> results = jss.Deserialize<List<DnD5thCharacter>>(jsonString);

            //Jesus Christ

            return currentDnDCharacter;
        }
    }
}

