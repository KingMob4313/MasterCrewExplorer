using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCrewExplorer
{
    abstract class Soldier : Person
    {
        private int health;
        private int accuracy;
        private int speed;
        private int strength;

        public int Health { get => health; set => health = value; }
        public int Accuracy { get => accuracy; set => accuracy = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Strength { get => strength; set => strength = value; }
    }
}
