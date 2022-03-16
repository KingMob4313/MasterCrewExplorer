using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCrewExplorer
{
    abstract class Adventurer : Person
    {
        private int hitPoints;
        private int classId;
        private int experience;

        public int HitPoints { get => hitPoints; set => hitPoints = value; }
        public int ClassId { get => classId; set => classId = value; }
        public int Experience { get => experience; set => experience = value; }
    }
}
