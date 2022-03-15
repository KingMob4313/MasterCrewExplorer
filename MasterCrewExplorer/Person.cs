using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCrewExplorer
{
    abstract class Person
    {
        private string codeName;
        //0 Female 1 Male 2 Other
        private int sex;
        private string pronounOne;
        private string pronounTwo;
        //0 child, 1 young .. 6 elderly
        private int age;
        //Day out of 365.24 : In case its translating to a game that has a weird year number
        private int birthdayDay;

        public string CodeName { get => codeName; set => codeName = value; }
        public int Sex { get => sex; set => sex = value; }
        public string PronounOne { get => pronounOne; set => pronounOne = value; }
        public string PronounTwo { get => pronounTwo; set => pronounTwo = value; }
        public int Age { get => age; set => age = value; }
        public int BirthdayDay { get => birthdayDay; set => birthdayDay = value; }
    }
}
