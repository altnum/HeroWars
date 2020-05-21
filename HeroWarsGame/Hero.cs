 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace HeroWarsGame
{
    abstract class Hero
    {
        protected string name;
        protected string gender;
        protected string _class;
        protected string race;
        protected int lvl = 1;
        protected int gold = 0;
        protected decimal dmg = 3;
        protected int health = 5;
        protected int wins = 0;
        protected int additionalDmg = 0;
        protected string enemy = "";
        //protected int AttackSpeed = 

        public Hero(string name, string gender, string _class, string race) 
        {
            this.name = name;
            this.gender = gender;
            this._class = _class;
            this.race = race;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }     
        }
        public string Gender
        {
            get { return gender; } set { gender = value; }
        }

        public string _Class
        {
            get { return _class; }
            set { _class = value; }
        }
        public string Race
        {
            get { return race; }
        }
        public int Lvl
        {
            get { return lvl; }
            set
            {
                if (lvl >= 100)
                    lvl = 100;
                if (lvl < 100)
                    lvl = value;
            }
        }
        public int Gold
        {
            get { return gold; }
            set
            {
                gold = value;

            }
        }
        public int Wins
        {
            get { return wins; }
            set
            {
                wins = value;

            }
        }
        public virtual decimal Dmg
        {
            get { return dmg; }
            set
            {
                dmg = value;
            }
        }
        public int Health
        {
            get
            {
                if (lvl > 5)
                    health = lvl;

                return health;
            }
            set
            { ; }
        }
        public string Enemy
        {
            get { return enemy; }
            set { enemy = value; }
        }
        public abstract int AdditionalDmg();


    }
}
