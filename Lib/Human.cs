using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroWarsGame
{
    public class Human : Hero
    {

        public Human(string name, string gender, string _class) : base(name, gender, _class, "Human")
        {
        }
        public override decimal Dmg
        {
            get
            {

                return dmg;
                
            }

        }
        public override int AdditionalDmg()
        {
            if (enemy == "Goblin")
            {
                additionalDmg = (int)(Math.Round(dmg * 20 / 100));
                return additionalDmg;
            }
            return 0;
        }
    }
}