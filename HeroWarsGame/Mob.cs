using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroWarsGame
{
 
    class Mob : Hero
    {
        internal Mob(int Herolevel) : base("Mob","Male", GetRandomClass() , GetRandomRace())
        {
            Random rnd = new Random();
            int symbol = rnd.Next(0, 1);
            int selecter = rnd.Next(0, 2);
            int addative;
            if (symbol == 0)
                addative = selecter;
            else
                addative = -selecter;

            if (Herolevel + addative < 100)
                lvl = Herolevel + addative;
            else
                lvl = 100;
            if (Herolevel > 5)
                health = lvl;
        }

        internal static string GetRandomClass()
        {
            Random rnd = new Random();
            string[] classlist = new string[3] { "Archer", "Mage", "Gunner" };
            int selector = rnd.Next(0, 2);
            return classlist[selector];
        }
        internal static string GetRandomRace()
        {
            Random rnd = new Random();
            string[] racelist = new string[3] { "Orc", "Troll", "Goblin" };
            int selector = rnd.Next(0, 2);
            return racelist[selector];
        }
        internal string _Class
        {
            get { return _class; }
        }
        internal string Race
        {
            get { return race; }
 
        }
        internal int Health
        {
            get {
                if (lvl > 5)
                    health = lvl;
                return health; }
        }
        internal int Gold
        {
            get { return 2 * lvl; }

        }
        public override decimal Dmg
        {
            get {
                dmg = Math.Ceiling((decimal)lvl * 20 / 100);
                return dmg;
            }

        }
        public override int AdditionalDmg()
        {
            if (race == "Orc")
            { if (enemy == "Elf")
                    additionalDmg = (int)Math.Ceiling(dmg * 20 / 100);
            }
            if (race == "Troll")
            { if (enemy == "Human")
                    additionalDmg = (int)Math.Ceiling(dmg * 20 / 100);
            }
            if (race == "Goblin")
            {
                if (enemy == "Dwarf")
                    additionalDmg = (int)Math.Ceiling(dmg * 20 / 100);
            }
            return additionalDmg;
        }

    }
}
