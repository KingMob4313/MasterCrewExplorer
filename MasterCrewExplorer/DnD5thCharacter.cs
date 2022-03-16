using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCrewExplorer
{
    class DnD5thCharacter : DnDBasicsCharacter
    {
        private int raceID;
        private int proficiency;
        private int initiative;

        public int RaceID { get => raceID; set => raceID = value; }
        public int Proficiency { get => proficiency; set => proficiency = value; }
        public int Initiative { get => initiative; set => initiative = value; }
    }
}
