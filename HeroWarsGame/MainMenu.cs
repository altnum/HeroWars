using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HeroWarsGame
{
    public partial class MainMenu : Form
    {
        Save save = new Save();
        public MainMenu()
        {
            
            InitializeComponent();


            string PictureBox = save.GetHeroPictureBox();
            MM_CharPreview.Image = (Image)HeroWarsGame.Properties.Resources.ResourceManager.GetObject(PictureBox);
            MM_CharName.Text = Saves.SetHeroName.ToString();

            UpdateCurInfo();
            UpdateUsers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MM_ToBattle_Click(object sender, EventArgs e)
        {
            UpdateHeroInfo();
            save.UpdateSaved();
            UpdateUsers();

            this.Hide();
            Battle battle = new Battle();
            battle.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateHeroInfo();
            UpdateCurInfo();
            save.UpdateSaved();
            UpdateUsers();

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
            UpdateCurInfo();

            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.ShowDialog();
            this.Close();

        }

        private void MM_IncreaseDmg_Click(object sender, EventArgs e)
        {
            int gold = int.Parse(MM_Gold.Text);
            int dmg = int.Parse(MM_Dmg.Text);
            int lvl = int.Parse(MM_Level.Text);

            if (gold - (2 * lvl) >= 0)
            {
                gold -= 2 * lvl;
                dmg += 1;
                MM_Gold.Text = gold.ToString();
                MM_Dmg.Text = dmg.ToString();
                
            }
            else
            {
                MessageBox.Show("Not enough gold!");
            }
            UpdateHeroInfo();
            UpdateCurInfo();
            UpdateUsers();


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
        private void UpdateCurInfo()
        {
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
            UpdateUsers();
        }

        private void MM_CharName_Click(object sender, EventArgs e)
        {

        }

        public static void UpdateUsers()
        {
            using (StreamReader f = new StreamReader(@"D:\\HeroWarsSaves.txt"))
            {
                foreach (var c in LogIn.users)
                {
                    if (c.Name == LogIn.username)
                    {
                        c.Heroes = "";
                    }
                }
                while (!f.EndOfStream)
                {
                    string line = f.ReadLine();


                    foreach (var c in LogIn.users)
                    {
                        if (c.Name == LogIn.username)
                        {
                            if (c.Heroes.Length > 2)
                                c.Heroes += "/" + line;
                            else
                                c.Heroes += line;
                        }
                    }
                }
            }
            using (FileStream file = new FileStream(@"D:\\Users.txt", FileMode.Truncate, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(file);
                foreach (var c in LogIn.users)
                {

                    sw.WriteLine(c.Name + "|" + c.Password + "|" + c.Heroes);

                }
                sw.Close();
                sw.Dispose();
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (e.CloseReason == CloseReason.UserClosing);
        }
    }
}
