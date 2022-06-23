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

        public List<DnD5thCharacter> ParseJsonToDataList(string jsonString)
        {
            DnD35Character currentC = new DnD35Character();

            var jss = new JavaScriptSerializer();
            var results = jss.Deserialize<List<DnD5thCharacter>>(jsonString);

            //Cleanup data and only pass back valid characters
            foreach(DnD5thCharacter currentCharacter in results)
            {

            }

            return results;
        }
    }
}

