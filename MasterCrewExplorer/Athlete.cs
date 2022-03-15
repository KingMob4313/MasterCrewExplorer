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
        private int consistency;
        //Salary Range 0-10
        private int salary;
    }
}
