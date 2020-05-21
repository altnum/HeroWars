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
    public partial class MainMenu : Form
    {
        Save save = new Save();
        public MainMenu()
        {
            
            InitializeComponent();

            MM_CharName.Text = Saves.SetHeroName.ToString();

            string charLine = "";

            foreach (var n in Saves.heroes)
            {
                if (Saves.SetHeroName.ToString() == n.Name)
                {
                    MM_Level.Text = n.Lvl.ToString();
                    MM_Gold.Text = n.Gold.ToString();
                    MM_Dmg.Text = n.Dmg.ToString();
                    MM_Wins.Text = n.Wins.ToString();

                    charLine = n.Name + "," + n.Gender + "," + n._Class + "," + n.Race + "," +
                        n.Lvl + "," + n.Gold + "," + n.Dmg + "," + n.Health + "," + n.Wins;

                    break;
                }

            }
            save.UpdateCurFile(charLine);
            save.UpdateSaved();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MM_ToBattle_Click(object sender, EventArgs e)
        {
            UpdateHeroInfo();
            save.UpdateSaved();

            this.Hide();
            Battle battle = new Battle();
            battle.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateHeroInfo();
            save.UpdateSaved();

            this.Hide();
            Saves saves = new Saves();
            saves.ShowDialog();
            this.Close();
        }

        private void MM_CharPreview_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void MM_QuitStartMenu_Click(object sender, EventArgs e)
        {
            UpdateHeroInfo();
            save.UpdateSaved();

            this.Hide();
            StartMenu starmenu = new StartMenu();
            starmenu.ShowDialog();
            this.Close();

        }

        private void MM_IncreaseDmg_Click(object sender, EventArgs e)
        {
            int gold = int.Parse(MM_Gold.Text);
            int dmg = int.Parse(MM_Dmg.Text);

            if (gold - 10 >= 0)
            {
                gold -= 10;
                dmg += 1;
                MM_Gold.Text = gold.ToString();
                MM_Dmg.Text = dmg.ToString();
            }
            else
            {
                MessageBox.Show("Not enough gold!");
            }
            UpdateHeroInfo();
        }
        private void UpdateHeroInfo()
        {
            foreach (var n in Saves.heroes)
            {
                if (Saves.SetHeroName.ToString() == n.Name)
                {
                    n.Dmg = int.Parse(MM_Dmg.Text);
                    n.Gold = int.Parse(MM_Gold.Text);
                    n.Wins = int.Parse(MM_Wins.Text);
                    break;
                }

            }
        }
    }
}
