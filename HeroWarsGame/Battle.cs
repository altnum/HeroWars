using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroWarsGame
{
    public partial class Battle : Form
    {
        static int PlayerShotSpeed;
        static int MobShotSpeed;
        static int PHealth = Saves.SetHealth;
        static int MHealth;

        static bool isCharged = true;

        public Battle()
        {
            InitializeComponent();

            Mob mob = new Mob(Saves.SetLvl);
            MHealth = mob.Health;

            PlayerHealth.Text = PHealth.ToString();
            MobHealth.Text = MHealth.ToString();
            PlayerShotSpeed = 25;
            MobShotSpeed = 12;
            timer1.Start();

        }

        private void Battle_Load(object sender, EventArgs e)
        {

        }
    }
}
