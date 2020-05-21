using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroWarsGame
{
    class Dwarf : Hero
    {
        public Dwarf(string name, string gender, string _class) : base(name, gender, _class, "Dwarf")
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
            if (enemy == "Orc")
            {
                additionalDmg = (int)(Math.Ceiling(dmg * 20 / 100));
                return additionalDmg;
            }
            return 0;    
        }

    }
}
