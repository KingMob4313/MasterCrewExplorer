namespace MasterCrewExplorer
{
    abstract class DnDBasicsCharacter : Adventurer
    {
        private int? strength;
        private int? dexterity;
        private int? constitution;
        private int? intelligence;
        private int? wisdom;
        private int? charisma;
        private int? speed;

        private int? level;
        private int? pcClass;
        private int? armorClass;
        private int[,] alignment;

        public int? Strength { get => strength; set => strength = value; }
        public int? Dexterity { get => dexterity; set => dexterity = value; }
        public int? Constitution { get => constitution; set => constitution = value; }
        public int? Intelligence { get => intelligence; set => intelligence = value; }
        public int? Wisdom { get => wisdom; set => wisdom = value; }
        public int? Charisma { get => charisma; set => charisma = value; }
        public int? Level { get => level; set => level = value; }
        public int? PCClass { get => pcClass; set => pcClass = value; }
        //Working to lower armor classes
        public int? ArmorClass { get => (20 - armorClass); }
        public int? Speed { get => speed; set => speed = value; }
        public int[,] Alignment { get => alignment; set => alignment = value; }
    }
}
