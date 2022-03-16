using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCrewExplorer
{
    abstract class Athlete: Person
    {
        private int sportID;
        private string position;
        private int speed;
        //discipline or consistency
        private int consistency;
        //Salary Range 0-10
        private int salary;
        private int seasons;

        public int SportID { get => sportID; set => sportID = value; }
        public string Position { get => position; set => position = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Consistency { get => consistency; set => consistency = value; }
        public int Salary { get => salary; set => salary = value; }
        public int Seasons { get => seasons; set => seasons = value; }
    }
}
