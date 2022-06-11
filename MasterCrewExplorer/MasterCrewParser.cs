using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            //var xyz = JsonConvert.DeserializeObject(jsonString);

            JArray xyz = JArray.Parse(jsonString);
            List<DnD5thCharacter> characterList = new List<DnD5thCharacter>();
            List<JObject> CurrentEntry = JsonConvert.DeserializeObject<JArray>(jsonString).ToObject<List<JObject>>();

            foreach (JObject dndPerson in CurrentEntry)
            {
                DnD5thCharacter currentCharacter = new DnD5thCharacter();
                var taco = dndPerson.SelectToken("Strength");
                if (taco == null)
                {
                    continue;
                }
                if (taco.HasValues == false)
                {
                    continue;
                }

                JToken strengthToken = null;
                JToken dexterityToken = null;
                JToken constitutionToken = null;
                JToken intelligenceToken = null;
                JToken wisdomToken = null;
                JToken charismaToken = null;
                dndPerson.TryGetValue("Strength", out strengthToken);
                if (strengthToken != null) continue;
                dndPerson.TryGetValue("Dexterity", out dexterityToken);
                dndPerson.TryGetValue("Constitution", out constitutionToken);
                dndPerson.TryGetValue("Intelligence", out intelligenceToken);
                dndPerson.TryGetValue("Wisdom", out wisdomToken);
                dndPerson.TryGetValue("Charisma", out charismaToken);
            }

            //foreach (JToken yyy in xyz)
            //{
            //    DnD5thCharacter currentCharacter = new DnD5thCharacter();
            //    var lodogsd = yyy.Children()["Strength"].Value<string>();
            //    foreach (JToken zzz in yyy)
            //    {
            //        string vel = zzz.First.Value<string>();


            //        if(vel == "1")
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            string stre = zzz.SelectToken("$.Strength").Value<string>();
            //        }

            //    }
            //}

            //var abc = JsonConvert.DeserializeObject<List<DnD5thCharacter>>(jsonString);
            return currentDnDCharacter;
        }
    }
}

