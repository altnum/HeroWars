using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroWarsGame
{
   public class Elf : Hero
    {
        public Elf(string name, string gender, string _class) : base(name, gender, _class, "Elf")
        {
        }
        public override decimal Dmg
        {
            get
            {
                return (int)dmg;
            }

        }
        public override int AdditionalDmg()
        {
            if (enemy == "Troll")
            {
                additionalDmg = (int)(Math.Ceiling(dmg * 20 / 100));
                return additionalDmg;
            }
            return 0;
        }
    }
}
