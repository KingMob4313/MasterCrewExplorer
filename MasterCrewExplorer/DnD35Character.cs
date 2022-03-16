using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCrewExplorer
{
    class DnD35Character : DnDBasicsCharacter
    {
        private int raceID;
        private int baseAttack;
        private int initiative;

        public int RaceID { get => raceID; set => raceID = value; }
        public int BaseAttack { get => baseAttack; set => baseAttack = value; }
        public int Initiative { get => initiative; set => initiative = value; }
    }
}
