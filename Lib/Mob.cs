using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroWarsGame
{
 
    public class Mob : Hero
    {
        public Mob(int Herolevel) : base("Mob","Male", GetRandomClass() , GetRandomRace())
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

            int selector = rnd.Next(1, 12);

            if (selector >= 1 && selector < 5)
                return classlist[0];
            else if (selector >= 5 && selector < 9)
                return classlist[1];
            else if (selector >= 9 && selector < 12)
                return classlist[2];
            return "Archer";

        }
        internal static string GetRandomRace()
        {
            Random rnd = new Random();
            string[] racelist = new string[3] { "Goblin", "Troll", "Orc" };

            int selector = rnd.Next(0, 13);


            if (selector >= 1 && selector < 5)
                return racelist[0];
            else if (selector >= 5 && selector < 9)
                return racelist[1];
            else if (selector >= 9 && selector < 12)
                return racelist[2];
            return "Orc";
        }
        internal string _Class
        {
            get { return _class; }
        }
        internal string Race
        {
            get { return race; }
 
        }
        public int Health
        {
            get {
                if (lvl > 5)
                    health = lvl;
                return health; }
        }
        public int Gold
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
