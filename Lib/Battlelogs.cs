using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    [Serializable]
    public class Battlelogs
    {
        public Battlelogs(string User, string Mob, string Outcome)
        {
            this.user = User;
            this.mob = Mob;
            this.outcome = Outcome;
        }

        public Battlelogs()
        {
        }

        public string user = "";
        public string mob = "";
        public string outcome = "";

        
    }
}
