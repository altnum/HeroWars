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
    public partial class CharacterCreator : Form
    {
        public CharacterCreator()
        {
            InitializeComponent();
        }

        private void CC_NameBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void CC_Create_Click(object sender, EventArgs e)
        {
            
            Save save = new Save();
            string Name = "";
            string Gender = "";
            try
            {
                save.RefreshCharNames();
                if (!CC_NameBox.Text.Any(char.IsDigit) && CC_NameBox.Text != "")
                {
                    bool contains = false;

                    using (StreamReader readNames = File.OpenText(@"D:\\Names.txt"))
                    {
                        while (!readNames.EndOfStream)
                        {
                            string line = readNames.ReadLine();
                            if (CC_NameBox.Text == line)
                                contains = true;
                        }
                    }
                    if (!contains)
                        Name = CC_NameBox.Text;
                    else
                    {
                        MessageBox.Show("Name already taken!");
                        throw new Exception("Name already taken!");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid name. Please try again!");
                    throw new Exception("Invalid name!");
                }

                if (CC_Male.Checked)
                    Gender = "Male";
                else if (CC_Female.Checked)
                    Gender = "Female";
                else if (!CC_Male.Checked && !CC_Female.Checked && Gender == "")
                {
                    MessageBox.Show("Gender not selected!");
                    throw new Exception("Gender not selected!");
                }



                string race;
                if (CC_RaceList.SelectedItem == null)
                {
                    MessageBox.Show("Race not selected!");
                    throw new Exception("No race selected!");
                }
                else
                {
                    race = CC_RaceList.SelectedItem.ToString();
                }



                string _class;
                if (CC_ClassList.SelectedItem == null)
                {
                    MessageBox.Show("Class not selected!");
                    throw new Exception("No class selected!");
                }
                else
                {
                    _class = CC_ClassList.SelectedItem.ToString();
                }


                Hero player;

                if (race.ToString() == "Human") player = new Human(Name, Gender, _class);
                else if (race.ToString() == "Elf") player = new Elf(Name, Gender, _class);
                else player = new Dwarf(Name, Gender, _class);


                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Are you sure?", "", buttons);
                if (result == DialogResult.Yes)
                {

                    string filePath = @"D:\\HeroWarsSaves.txt";
                    string SaveContents = player.Name + "," + player.Gender + "," + player._Class + "," + player.Race +
                            "," + player.Lvl + "," + player.Gold + "," + player.Dmg + "," + player.Health + "," + player.Wins;


                    using (FileStream file = new FileStream(filePath, FileMode.Append, FileAccess.Write))
                    {
                        StreamWriter sw = new StreamWriter(file);
                        sw.WriteLine(SaveContents);
                        sw.Close();
                    }



                    this.Hide();
                    Saves saves = new Saves();
                    saves.ShowDialog();
                    this.Close();


                }
                else
                    return;
            }
            catch
            { }
            
        }

        private void CharacterCreator_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you wish to cancel?", "", buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                StartMenu startmenu = new StartMenu();
                startmenu.ShowDialog();
                this.Close();
            }
        }

        private void CC_RacePerks_Click(object sender, EventArgs e)
        {
            RacePerks raceperks = new RacePerks();
            raceperks.ShowDialog();
        }

        private void CC_ClassSpecs_Click(object sender, EventArgs e)
        {
            ClassSpecs classpecs = new ClassSpecs();
            classpecs.ShowDialog();
        }
    }
}
