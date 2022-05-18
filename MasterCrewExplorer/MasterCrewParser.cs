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
            //var xyz = JsonConvert.DeserializeObject(jsonString);
            JArray xyz = JArray.Parse(jsonString);
            List<DnD5thCharacter> characterList = new List<DnD5thCharacter>();
            //ChildrenTokens xxx = null;
            foreach (JToken yyy in xyz)
            {
                DnD5thCharacter currentCharacter = new DnD5thCharacter();
                JEnumerable<JToken> tempChar = yyy.Children();
                var asadsd = tempChar.Values("Strength");
                if (tempChar[2].ToString() != null)
                {
                    int tempStr = 0;
                    int.TryParse(tempChar["Strength"].ToString(), out tempStr);
                    currentCharacter.Strength = tempStr;
                }

            }

            //var abc = JsonConvert.DeserializeObject<List<DnD5thCharacter>>(jsonString);
            return currentDnDCharacter;
        }
    }
}

